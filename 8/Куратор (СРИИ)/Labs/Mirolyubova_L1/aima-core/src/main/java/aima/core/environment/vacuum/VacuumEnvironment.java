package aima.core.environment.vacuum;

import aima.core.agent.action.Action;
import aima.core.agent.action.impl.DynamicAction;
import aima.core.agent.agents.Agent;
import aima.core.agent.environments.EnvironmentState;
import aima.core.agent.environments.impl.AbstractEnvironment;
import aima.core.agent.percept.Percept;

import java.util.Random;

/**
 * Artificial Intelligence A Modern Approach (3rd Edition): pg 58.<br>
 * <br>
 * Let the world contain just two locations. Each location may or may not
 * contain dirt, and the agent may be in one location or the other. There are 8
 * possible world states, as shown in Figure 3.2. The agent has three possible
 * actions in this version of the vacuum world: <em>Left</em>, <em>Right</em>,
 * and <em>Suck</em>. Assume for the moment, that sucking is 100% effective. The
 * goal is to clean up all the dirt.
 *
 * @author Ravi Mohan
 * @author Ciaran O'Reilly
 * @author Mike Stampone
 */
public class VacuumEnvironment extends AbstractEnvironment {
    // Allowable Actions within the Vacuum Environment
    public static final Action ACTION_MOVE_LEFT = new DynamicAction("Left");
    public static final Action ACTION_MOVE_RIGHT = new DynamicAction("Right");
    public static final Action ACTION_MOVE_LEFT_TWICE = new DynamicAction("Left_Twice");
    public static final Action ACTION_MOVE_RIGHT_TWICE = new DynamicAction("Right_Twice");
    public static final Action ACTION_SUCK = new DynamicAction("Suck");
    public static final String LOCATION_A = "A";
    public static final String LOCATION_B = "B";
    public static final String LOCATION_C = "C";
    public static final String LOCATION_D = "D";

    public enum LocationState {
        Clean, Dirty
    }

    ;

    //
    protected VacuumEnvironmentState envState = null;
    protected boolean isDone = false;

    /**
     * Constructs a vacuum environments with four locations, in which dirt is
     * placed at random.
     */
    public VacuumEnvironment() {
        Random r = new Random();
        envState = new VacuumEnvironmentState(
                0 == r.nextInt(2) ? LocationState.Clean : LocationState.Dirty,
                0 == r.nextInt(2) ? LocationState.Clean : LocationState.Dirty,
                0 == r.nextInt(2) ? LocationState.Clean : LocationState.Dirty,
                0 == r.nextInt(2) ? LocationState.Clean : LocationState.Dirty);
    }

    /**
     * Constructs a vacuum environments with two locations, in which dirt is
     * placed as specified.
     *
     * @param locAState the initial state of location A, which is either
     *                  <em>Clean</em> or <em>Dirty</em>.
     * @param locBState the initial state of location B, which is either
     *                  <em>Clean</em> or <em>Dirty</em>.
     */
    public VacuumEnvironment(LocationState locAState, LocationState locBState, LocationState locCState, LocationState locDState) {
        envState = new VacuumEnvironmentState(locAState, locBState, locCState, locDState);
    }

    @Override
    public EnvironmentState getCurrentState() {
        return envState;
    }

    @Override
    public EnvironmentState executeAction(Agent a, Action agentAction) {

        if (ACTION_MOVE_RIGHT == agentAction) {
            envState.setAgentLocation(a, LOCATION_B);
            updatePerformanceMeasure(a, -1);
        } else if (ACTION_MOVE_LEFT == agentAction) {
            envState.setAgentLocation(a, LOCATION_A);
            updatePerformanceMeasure(a, -1);
        } else if (ACTION_MOVE_LEFT_TWICE == agentAction) {
            envState.setAgentLocation(a, LOCATION_C);
            updatePerformanceMeasure(a, -2);
        } else if (ACTION_MOVE_RIGHT_TWICE == agentAction) {
            envState.setAgentLocation(a, LOCATION_D);
            updatePerformanceMeasure(a, -2);
        } else if (ACTION_SUCK == agentAction) {
            if (LocationState.Dirty == envState.getLocationState(envState
                    .getAgentLocation(a))) {
                envState.setLocationState(envState.getAgentLocation(a),
                        LocationState.Clean);
                updatePerformanceMeasure(a, 10);
            }
        } else if (agentAction.isNoOp()) {
            // In the Vacuum Environment we consider things done if
            // the agent generates a NoOp.
            isDone = true;
        }

        return envState;
    }

    @Override
    public Percept getPerceptSeenBy(Agent anAgent) {
        if (anAgent instanceof NondeterministicVacuumAgent) {
            // Note: implements FullyObservableVacuumEnvironmentPercept
            return new VacuumEnvironmentState(this.envState);
        }
        String agentLocation = envState.getAgentLocation(anAgent);
        return new LocalVacuumEnvironmentPercept(agentLocation,
                envState.getLocationState(agentLocation));
    }

    @Override
    public boolean isDone() {
        return super.isDone() || isDone;
    }

    @Override
    public void addAgent(Agent a) {
        int idx = new Random().nextInt(4);
        switch (idx) {
            case (0): {
                envState.setAgentLocation(a, LOCATION_C);
                break;
            }
            case (1): {
                envState.setAgentLocation(a, LOCATION_A);
                break;
            }
            case (2): {
                envState.setAgentLocation(a, LOCATION_B);
                break;
            }
            default:envState.setAgentLocation(a, LOCATION_D);

        }
        super.addAgent(a);
    }

    public void addAgent(Agent a, String location) {
        // Ensure the agent state information is tracked before
        // adding to super, as super will notify the registered
        // EnvironmentViews that is was added.
        envState.setAgentLocation(a, location);
        super.addAgent(a);
    }

    public LocationState getLocationState(String location) {
        return envState.getLocationState(location);
    }

    public String getAgentLocation(Agent a) {
        return envState.getAgentLocation(a);
    }
}