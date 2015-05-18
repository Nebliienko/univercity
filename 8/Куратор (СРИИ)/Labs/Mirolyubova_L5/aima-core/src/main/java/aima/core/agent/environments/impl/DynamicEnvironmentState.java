package aima.core.agent.environments.impl;

import aima.core.agent.environments.EnvironmentState;
import aima.core.agent.ObjectWithDynamicAttributes;

/**
 * @author Ravi Mohan
 * @author Ciaran O'Reilly
 */
public class DynamicEnvironmentState extends ObjectWithDynamicAttributes
		implements EnvironmentState {
	public DynamicEnvironmentState() {

	}

	@Override
	public String describeType() {
		return EnvironmentState.class.getSimpleName();
	}
}