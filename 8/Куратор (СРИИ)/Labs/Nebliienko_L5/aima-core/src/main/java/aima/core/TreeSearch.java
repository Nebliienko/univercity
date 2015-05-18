package aima.core;

import aima.core.agent.action.Action;
import aima.core.search.framework.Node;
import aima.core.search.framework.Problem;

import java.util.ArrayList;
import java.util.List;

public class TreeSearch {

	public static List<Node> expand(Node parentNode, Problem p) {
		List<Node> successors = new ArrayList();
		Node s = null;
		
		List<Action> applicableActions = parentNode.getApplicableActions(p);
		Result tmp;
		foreach (Action a: applicableActions) {
			s.setState(parentNode.applyAction(a).getResult());
			s.setParentNode(parentNode);
			s.setActionToGetIt(a);
			s.setPathCost(parentNode.getPathCost() + a.getStepCost(parentNode, a, s));
			s.setDepth(parentNode.getDepth() + 1);
			successors.add(s);
		}
		return successors;
	}
	public static Solution treeSearch (Problem p, Fringe fringe) {
		Solution s = null;
		Node node;
		fringe.insert(makeNode(p.getInitialState()), fringe);
		
		for (;;) {
			if (fringe.isEmpty()) {
				return s;
			}
			if (p.isGoalState(node)) {
				return solution.getTrackTo(node);
			}
			fringe.insertAll(expand(node, p), fringe);
		}		
		return s;
	}
}
