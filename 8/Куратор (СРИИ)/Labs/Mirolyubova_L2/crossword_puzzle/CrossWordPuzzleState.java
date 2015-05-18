package aima.core.environment.crossword_puzzle;

import aima.core.agent.environments.EnvironmentState;

import java.util.Set;

public class CrossWordPuzzleState implements EnvironmentState {

    private Field field;
    private Set<Word> words;

    public CrossWordPuzzleState(Field field, Set<Word> words) {
        this.field =  field;
        this.words = words;
    }

    public Field getField() {
        return field;
    }

    public void setField(Field field) {
        this.field = field;
    }

    public Set<Word> getWords() {
        return words;
    }

    public void setWords(Set<Word> words) {
        this.words = words;
    }
}
