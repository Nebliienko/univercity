package aima.core.crossword_puzzle.enviroment;

import aima.core.agent.action.Action;
import aima.core.agent.action.impl.DynamicAction;
import aima.core.agent.agents.Agent;
import aima.core.agent.environments.EnvironmentState;
import aima.core.crossword_puzzle.CrossWordPuzzleState;
import aima.core.crossword_puzzle.enviroment.object.FieldEnviromentObject;
import aima.core.crossword_puzzle.enviroment.object.Word;
import aima.core.crossword_puzzle.enviroment.object.WordsEnviromentObject;
import aima.core.crossword_puzzle.actions.AddWordAction;
import aima.core.crossword_puzzle.actions.RemoveWordAction;

import java.util.HashSet;

public class CrossWordPuzzleEnviroment extends AbstractCrossWordPuzzleEnvironment {

    boolean puzzleFilled;

    @Override
    protected void initGame() {
        addEnvironmentObject(new FieldEnviromentObject());
        addEnvironmentObject(new WordsEnviromentObject(new HashSet<Word>()));
    }

    @Override
    public EnvironmentState executeAction(Agent agent, Action action) {
        CrossWordPuzzleState state = (CrossWordPuzzleState) getCurrentState();
        if (state.getWords().getWordsNumber() == state.getField().getQuestionsNumber()) {
            agent.setAlive(false);
            finishGame();
        }
        if(agent.isAlive()){
            if (!action.isNoOp()) {
                DynamicAction dynamic = (DynamicAction) action;
                if (dynamic.getName().equals("addAction")) {
                    AddWordAction add = (AddWordAction) action;
                    state.getWords().addWord(add.getWord());
                }
                if (dynamic.getName().equals("removeAction")) {
                    RemoveWordAction remove = (RemoveWordAction) action;
                    state.getWords().removeWord(remove.getWord());
                }
            }
        }
        return super.executeAction(agent, action);
    }

    @Override
    protected void finishGame() {
        puzzleFilled = true;
    }
}
