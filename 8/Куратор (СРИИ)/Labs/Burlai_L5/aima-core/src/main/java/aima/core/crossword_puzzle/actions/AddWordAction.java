package aima.core.crossword_puzzle.actions;

import aima.core.crossword_puzzle.enviroment.object.Word;

public class AddWordAction extends CrossWordPuzzleDynamicAction {

    public AddWordAction(Word words) {
        super("addWord");
        setWord(words);
    }

    @Override
    public boolean isNoOp() {
        return false;
    }

}
