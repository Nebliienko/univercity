/**
 * Реализация альфа-бета процедуры
 */
public class AlphaBetaSolver<TField extends Field> extends Solver<TField> {

    public int alphaBeta(TField field, Move move, int player, int alpha, int beta,
            int depth) {
        if (field.isGameOver() || depth == maxDepth) {
            int score = heuristic.score(field, player, move);
            return score;
        }
        int score = Integer.MIN_VALUE;
        Move[] moves = rules.getMoves(player);
        for (Move m : moves) {
            field.doMove(m, player);
            int res = -alphaBeta(field, move, -player, -beta, -score, depth + 1);
            field.undoMove(m, player);
            score = (res > score) ? res : score;
            if (score > beta) {
                return score;
            }
        }
        return score;
    }

    public AlphaBetaSolver(Rules rules, int player, TField field,
            Heuristic<TField> heuristic, int maxDepth) {
        super(rules, player, field);
        if (rules == null) {
            throw new IllegalArgumentException("Rules can`t be null.");
        }
        this.heuristic = heuristic;
        this.maxDepth = maxDepth;
        LOG.debug("AlphaBetaSolver created with " + heuristic.getClass().getName()
                + " heuristic.");
    }

    @Override
    protected int score(TField field, int player, Move m) {
        return -alphaBeta(field, m, player, Integer.MIN_VALUE, Integer.MAX_VALUE, 0);
    }

    private final Heuristic<TField> heuristic;

    private int maxDepth;

   }