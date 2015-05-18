/**
 * Выполняет выбор наилучшего хода с помощью минимаксной процедуры.
 * 
 */
public class MiniMaxSolver<TField extends Field> extends Solver<TField> {

    @Override
    protected int score(TField field, int player, Move m) {
        return min(field, m, player, 1);
    }

    public int max(TField field, Move m, int player, int depth) {
        if (field.isGameOver() || depth == maxDepth) {
            int score = heuristic.score(field, player, m);
            return score;
        }
        int score = Integer.MIN_VALUE;
        Move[] moves = rules.getMoves(player);
        for (Move move : moves) {
            field.doMove(move, player);
            int res = min(field, move, -player, depth + 1);
            field.undoMove(move, player);
            score = (res > score) ? res : score;
        }
        return score;
    }

    public int min(TField field, Move m, int player, int depth) {
        if (field.isGameOver() || depth == maxDepth) {
            int score = -heuristic.score(field, player, m);
            return score;
        }
        int score = Integer.MAX_VALUE;
        Move[] moves = rules.getMoves(player);
        for (Move move : moves) {
            field.doMove(move, player);
            int res = max(field, move, -player, depth + 1);
            field.undoMove(move, player);
            score = (res < score) ? res : score;
        }
        return score;
    }

    public MiniMaxSolver(Rules rules, int player, TField field,
            Heuristic<TField> heuristic, int maxDepth) {
        super(rules, player, field);
        if (rules == null) {
            throw new IllegalArgumentException("Rules can`t be null.");
        }
        this.heuristic = heuristic;
        this.maxDepth = maxDepth;
    }

    private int maxDepth;
    
    private final Heuristic<TField> heuristic;
}
