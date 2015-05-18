package aima.core.environment.map;

/**
 * A scenario specifies an environments, the agent's knowledge about the
 * environments, and the agents initial location. It can be used to specify
 * settings for route planning agent applications.
 * 
 * @author Ruediger Lunde
 */
public class Scenario {
	/**
	 * A map-based environments. Note that the contained map must be of type
	 * {@link ExtendableMap}.
	 */
	private final MapEnvironment env;
	/** A map reflecting the knowledge of the agent about the environments. */
	private final Map agentMap;
	/** Initial location of the agent. */
	private final String initAgentLoc;

	/**
	 * Creates a scenario.
	 * 
	 * @param env
	 *            a map-based environments. Note that the contained map must be
	 *            of type {@link ExtendableMap}
	 * @param agentMap
	 *            a map reflecting the knowledge of the agent about the
	 *            environments
	 * @param agentLoc
	 *            initial location of the agent
	 */
	public Scenario(MapEnvironment env, Map agentMap, String agentLoc) {
		this.agentMap = agentMap;
		this.env = env;
		this.initAgentLoc = agentLoc;
	}

	public MapEnvironment getEnv() {
		return env;
	}

	public Map getEnvMap() {
		return env.getMap();
	}

	public Map getAgentMap() {
		return agentMap;
	}

	public String getInitAgentLocation() {
		return initAgentLoc;
	}
}
