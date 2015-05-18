package aima.core.crossword_puzzle;

import aima.core.agent.environments.EnvironmentState;
import aima.core.crossword_puzzle.enviroment.object.FieldEnviromentObject;
import aima.core.crossword_puzzle.enviroment.object.WordsEnviromentObject;

public class CrossWordPuzzleState implements EnvironmentState {

    private FieldEnviromentObject field;
    private WordsEnviromentObject words;

    public CrossWordPuzzleState(FieldEnviromentObject field, WordsEnviromentObject words) {
        this.field =  field;
        this.words = words;
    }

    public FieldEnviromentObject getField() {
        return field;
    }

    public void setField(FieldEnviromentObject field) {
        this.field = field;
    }

    public WordsEnviromentObject getWords() {
        return words;
    }

    public void setWords(WordsEnviromentObject words) {
        this.words = words;
    }
}
