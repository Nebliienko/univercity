package aima.core;

import aima.core.search.framework.Node;
import aima.core.search.framework.Problem;

public class DepthLimited {

	public static Solution depthLimitedSearch(Problem p, int limit) {
		Solution sol = null;
		return recursiveDLS(makeNode(p.getInitialState()), p, lim);
	}

	public static Solution recursiveDLS(Node node, Problem p, int lim) {
		Solution s = null;
		Node node;
		boolean cutOffOccurred = false;

		if (p.isGoalState(node)) {
			return solution.getTrackTo(node);
		} else if (node.getDepth() == limit) {
			return DepthLimited.returnCutOff();
		}
		
		List<Node> successors = expand(node, p));
		else  {
			foreach (Node n:successors) {
				Result tmp = recursiveDLS(n,p,lim);
				if (tmp.isCutOff) {
					cutOffOccurred = true;
				} else if (p.isFailure(tmp)) {
					return tmp;
				}
			}			
		}
		
		if (cutOffOccurred) {
			return DepthLimited.returnCutOff();
		} else {
			return s;
		}
	}
}
