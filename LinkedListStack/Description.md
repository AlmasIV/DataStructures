# The Stack that uses custom doubly-linked list internally.

First let's see doubly-linked list's operation types and their time complexities.

| Operation Type | Time Complexity |
|:------------:|:-------------:|
| Adding a new item | O(1) |
| Inserting a new item to the specified position | O(n) |
| Removing an item from the specified position | O(n) |
| Getting node's data at the specified position | O(n) |
| Popping the last element | O(1) |

For the stack I used the first, and the second operation types.

Now we have O(1) for the stack's most important operations: popping an item, and adding an item.

This stack can be traversed via foreach.