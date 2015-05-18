package aima.core.crossword_puzzle.enviroment.object;

import aima.core.agent.environments.EnvironmentObject;

public class Word implements EnvironmentObject{

    private int questionNumber;
    private String answer;
    private WordPosition position;

    public WordPosition getPosition() {
        return position;
    }

    public void setPosition(WordPosition position) {
        this.position = position;
    }

    public int getQuestionNumber() {
        return questionNumber;
    }

    public void setQuestionNumber(int questionNumber) {
        this.questionNumber = questionNumber;
    }

    public String getAnswer() {
        return answer;
    }

    public void setAnswer(String answer) {
        this.answer = answer;
    }
}
