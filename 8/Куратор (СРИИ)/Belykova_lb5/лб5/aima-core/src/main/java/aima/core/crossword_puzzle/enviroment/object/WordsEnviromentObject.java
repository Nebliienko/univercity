package aima.core.crossword_puzzle.enviroment.object;

import aima.core.agent.environments.EnvironmentObject;

import java.util.Set;

public class WordsEnviromentObject implements EnvironmentObject {
    private Set<Word> words;

    public WordsEnviromentObject(Set<Word> words) {
        this.words = words;
    }

    public Set<Word> getWords() {
        return words;
    }

    public void setWords(Set<Word> words) {
        this.words = words;
    }

    public int getWordsNumber() {
        return words.size();
    }

    public void addWord(Word word){
        words.add(word);
    }

    public void removeWord(Word word) {
        words.remove(word);
    }
}
