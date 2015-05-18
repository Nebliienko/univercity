package aima.core.environment.crossword_puzzle;

import aima.core.agent.environments.EnvironmentObject;
import aima.core.agent.percept.Percept;

import java.util.List;

public class PuzzlePercept implements Percept {

    private List<EnvironmentObject> envObjects;

    public PuzzlePercept(List<EnvironmentObject> environmentObjects) {
        this.envObjects = environmentObjects;
    }

    public List<EnvironmentObject> getEnvObjects() {
        return envObjects;
    }

    public void setEnvObjects(List<EnvironmentObject> envObjects) {
        this.envObjects = envObjects;
    }
}
