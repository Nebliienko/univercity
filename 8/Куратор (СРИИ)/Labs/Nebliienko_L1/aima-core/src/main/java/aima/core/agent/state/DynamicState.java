package aima.core.agent.state;

import aima.core.agent.ObjectWithDynamicAttributes;
import aima.core.agent.state.State;

/**
 * @author Ciaran O'Reilly
 */
public class DynamicState extends ObjectWithDynamicAttributes implements State {
	public DynamicState() {

	}

	@Override
	public String describeType() {
		return State.class.getSimpleName();
	}
}