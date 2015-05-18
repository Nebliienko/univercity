package aima.search;

import aima.core.search.framework.Node;
import aima.core.search.framework.Problem;

public class HighLevelTreeSearch {

	public static Solution treeSearch(Problem p, Strategy s) {
		Solution s = null;
				
		
		Fringe fringe = p.getInitialState().getNode();
		Node node = fringe.getNode(); // it should substract this node from the fringe
		
		for (;;) {
			if (fringe.size() == 0) {
				return null; 
			}
			if (p.isGoalState(node)) {
				return s;
			} else {				
				fringe.add(node.expand);
			}
		}
		
		return s;
	}
	
	
}