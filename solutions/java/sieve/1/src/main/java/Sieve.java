import java.util.*;

class Sieve {
    private List<Integer> _primes = new ArrayList<Integer>();
    
    Sieve(int maxPrime) {
        for (int i = 2; i <= maxPrime; i++) {
            _primes.add(i);
        }
    }

    List<Integer> getPrimes() {
        if (_primes.size() == 0) return _primes;
        
        int i = 0;
        while(true) {
            int currentNum = _primes.get(i);
            for (int j = i+1; j < _primes.size(); j++) {
                if (_primes.get(j) % currentNum == 0) {
                    _primes.remove(j);
                }
            }
            i++;
            if (i >= _primes.size()) return _primes;
        }
    }
}
