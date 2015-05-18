package aima.core.crossword_puzzle.actions;

import aima.core.crossword_puzzle.enviroment.object.Word;

public class RemoveWordAction extends CrossWordPuzzleDynamicAction{

    public RemoveWordAction(Word word) {
        super("removeAction");
        setWord(word);
    }

    @Override
    public boolean isNoOp() {
        return false;
    }
}
