package aima.core.agent.agents;

import aima.core.agent.Actuator;
import aima.core.agent.PerformanceMeasure;
import aima.core.agent.Sensor;
import aima.core.agent.agent_programs.AgentProgram;
import aima.core.agent.environments.EnvironmentState;
import aima.core.agent.percept.Percept;

import java.util.ArrayList;

public abstract class TaxiDriverAgent extends AbstractAgent {

    private ArrayList<Actuator> actuators;
    private ArrayList<Sensor> sensors;
    private ArrayList<PerformanceMeasure> performanceMeasures;

    public TaxiDriverAgent(AgentProgram program) {
        super();
    }

    public ArrayList<Actuator> getActuators() {
        return actuators;
    }

    public void setActuators(ArrayList<Actuator> actuators) {
        this.actuators = actuators;
    }

    public ArrayList<Sensor> getSensors() {
        return sensors;
    }

    public void setSensors(ArrayList<Sensor> sensors) {
        this.sensors = sensors;
    }

    public ArrayList<PerformanceMeasure> getPerformanceMeasures() {
        return performanceMeasures;
    }

    public void setPerformanceMeasures(ArrayList<PerformanceMeasure> performanceMeasures) {
        this.performanceMeasures = performanceMeasures;
    }

    public Percept createPercept() {
        ArrayList<Percept> sensorPercepts = new ArrayList<>();

        for (Sensor sensor : sensors)
            sensorPercepts.add(sensor.getPercept());

        return combineSensorPercepts(sensorPercepts);
    }

    protected abstract Percept combineSensorPercepts(ArrayList<Percept> sensorPercepts);

    public abstract double happinessMeasure(EnvironmentState state);

    public abstract boolean isAgentHappy(EnvironmentState state);

}
