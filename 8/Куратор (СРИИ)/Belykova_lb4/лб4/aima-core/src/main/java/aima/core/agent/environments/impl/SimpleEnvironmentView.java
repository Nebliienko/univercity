package aima.core.agent.environments.impl;

import aima.core.agent.action.Action;
import aima.core.agent.agents.Agent;
import aima.core.agent.environments.EnvironmentState;
import aima.core.agent.environments.EnvironmentView;

/**
 * Simple environments view which uses the standard output stream to inform about
 * relevant events.
 * 
 * @author Ruediger Lunde
 */
public class SimpleEnvironmentView implements EnvironmentView {
	@Override
	public void agentActed(Agent agent, Action action,
			EnvironmentState resultingState) {
		System.out.println("Agent acted: " + action.toString());
	}

	@Override
	public void agentAdded(Agent agent, EnvironmentState resultingState) {
		System.out.println("Agent added.");
	}

	@Override
	public void notify(String msg) {
		System.out.println("Message: " + msg);
	}
}
