# The stack that uses System.Collections.Generic.List<T> internally.

The stack implements IEnumerable<T> and IEnumerator<T>.

The stack also implements the custom IStack<T> interface.

|Operation Type | Time Complexity |
|:-------------:|:---------------:|
|Poping an item | O(N)            |
|Adding an item | O(1)            |