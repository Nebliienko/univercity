package aima.core.crossword_puzzle.enviroment;

import aima.core.agent.action.Action;
import aima.core.agent.agents.Agent;
import aima.core.agent.environments.EnvironmentObject;
import aima.core.agent.environments.EnvironmentState;
import aima.core.agent.environments.impl.AbstractEnvironment;
import aima.core.agent.percept.Percept;
import aima.core.crossword_puzzle.*;
import aima.core.crossword_puzzle.enviroment.object.FieldEnviromentObject;
import aima.core.crossword_puzzle.enviroment.object.Word;
import aima.core.crossword_puzzle.enviroment.object.WordsEnviromentObject;

import java.util.ArrayList;

public abstract class AbstractCrossWordPuzzleEnvironment extends AbstractEnvironment {

    private final int agentsMaxAmount = 1;
    protected WordsEnviromentObject words;
    protected FieldEnviromentObject field;

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

    public AbstractCrossWordPuzzleEnvironment()
    {
        super();
        initGame();
    }

    protected abstract void initGame();

    @Override
    public void addAgent(Agent a)
    {
        if(agents.size() < agentsMaxAmount)
            super.addAgent(a);
    }

    @Override
    public EnvironmentState getCurrentState()
    {
        for (EnvironmentObject eo : envObjects)
        {
            if(eo instanceof FieldEnviromentObject)
                field = (FieldEnviromentObject) eo;
            if(eo instanceof Word)
                words.getWords().add((Word) eo);
        }
        return new CrossWordPuzzleState(field, words);
    }

    @Override
    public EnvironmentState executeAction(Agent agent, Action action)
    {
        updateEnvironmentViewsAgentActed(agent, action, getCurrentState());
        return getCurrentState();
    }

    @Override
    public Percept getPerceptSeenBy(Agent anAgent)
    {
        return new PuzzlePercept((ArrayList<EnvironmentObject>) getEnvironmentObjects());
    }

    protected abstract void finishGame();
}
