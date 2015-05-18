package aima.core.environment.crossword_puzzle;

import aima.core.agent.action.Action;
import aima.core.agent.agents.Agent;
import aima.core.agent.environments.EnvironmentObject;
import aima.core.agent.environments.EnvironmentState;
import aima.core.agent.environments.impl.AbstractEnvironment;
import aima.core.agent.percept.Percept;

import java.util.ArrayList;
import java.util.HashSet;
import java.util.Set;

public abstract class CrossWordPuzzleEnvironment extends AbstractEnvironment {

    private final int agentsMaxAmount = 1;

    public CrossWordPuzzleEnvironment()
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
        Field field = null;
        Set<Word> words = new HashSet<Word>();

        for (EnvironmentObject eo : envObjects)
        {
            if(eo instanceof Field)
                field = (Field) eo;
            if(eo instanceof Word)
                words.add((Word) eo);
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
