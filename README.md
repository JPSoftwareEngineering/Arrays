# Arrays

## Static Arrays

A static array is a container of fixed length and is indexable. Arrays are also given as a contiguous chunk of memory, i.e. in other words the memory
cells allocated to the array does not have any gaps, they are sequential.

## Dynamic Arrays

Dynamic arrays can grow and shrink in size.

## Implementing a Dynamic Array

One approach of implementing a dynamic array is to:

1. Create a static array with an initial capacity.
2. Add elements to the static array keeping track of the number of elements.
3. If adding another element will exceed the capacity, then create a new static array with twice the capacity and copy the original elements into it.

```
```

### Learnings

**Overriding**



## Complexity of Arrays

| Operation | Static Arrays | Dynamic Arrays |
|-----------|---------------|----------------|
| Access    | O(1)          | O(1)           |
| Search    | O(N)          | O(N)           |
| Insertion | N/A           | O(N)           |
| Appending | N/A           | O(1)           |
| Deletion  | N/A           | O(N)           |
