package aima.core.crossword_puzzle.enviroment.object;

import aima.core.agent.environments.EnvironmentObject;

public class FieldEnviromentObject implements EnvironmentObject {

    private int questionsNumber;
    private int verticalPositionNumber;
    private int horizontalPositionNumber;

    public int getQuestionsNumber() {
        return questionsNumber;
    }

    public void setQuestionsNumber(int questionsNumber) {
        this.questionsNumber = questionsNumber;
    }

    public int getVerticalPositionNumber() {
        return verticalPositionNumber;
    }

    public void setVerticalPositionNumber(int verticalPositionNumber) {
        this.verticalPositionNumber = verticalPositionNumber;
    }

    public int getHorizontalPositionNumber() {
        return horizontalPositionNumber;
    }

    public void setHorizontalPositionNumber(int horizontalPositionNumber) {
        this.horizontalPositionNumber = horizontalPositionNumber;
    }
}
