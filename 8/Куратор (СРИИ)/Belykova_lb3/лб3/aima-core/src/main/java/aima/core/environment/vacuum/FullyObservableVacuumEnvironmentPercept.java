package aima.core.environment.vacuum;

import aima.core.agent.agents.Agent;
import aima.core.agent.percept.Percept;

/**
 * Implements a fully observable environments percept, in accordance with page
 * 134, AIMAv3.
 *
 * @author Andrew Brown
 */
public interface FullyObservableVacuumEnvironmentPercept extends Percept {
	/**
     * Returns the agent location
     *
     * @param a
     * @return the agents location
     */
    String getAgentLocation(Agent a);
    
    /**
     * Returns the location state
     *
     * @param location
     * @return the location state
     */
    VacuumEnvironment.LocationState getLocationState(String location);
}
