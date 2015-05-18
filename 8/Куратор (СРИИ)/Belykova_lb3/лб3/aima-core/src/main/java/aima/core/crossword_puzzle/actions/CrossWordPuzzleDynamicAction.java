package aima.core.crossword_puzzle.actions;

import aima.core.agent.action.impl.DynamicAction;
import aima.core.crossword_puzzle.enviroment.object.Word;

public class CrossWordPuzzleDynamicAction extends DynamicAction {

    private Word word;

    public Word getWord() {
        return word;
    }

    public void setWord(Word word) {
        this.word = word;
    }

    public CrossWordPuzzleDynamicAction(String name) {
        super(name);
    }
}
