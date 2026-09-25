Unixtensions is a package that contains many extension methods for popular classes in Unity that you can use to write more expressive and concise code.

Add these imports to your script:

```csharp
using System.Collections.Generic;
using UnityEngine;
using Unixtensions;
```

Use the following examples inside a `MonoBehaviour` method, where `transform` refers to the current object:

```csharp
// Set the world-space X position.
transform.SetPositionX(1f);

// Set the local X and Z Euler angles.
transform.SetLocalEulerAnglesXZ(45f, 90f);

// Reset local position to zero, local rotation to identity, and local scale to one.
transform.Reset();

// Move to the next sibling index in the hierarchy.
transform.SetToNextSibling();

// Get the transforms of all direct children.
var children = transform.GetChilds();

// Destroy direct child game objects that match the condition.
transform.DestroyChildsWhere(child => child.name == "Enemy");

// Return a modified vector copy and assign it back to the position.
transform.position = transform.position.WithY(0f);

// Reorder vector components from [x, y, z] to [z, x, y].
var vector = new Vector3(1f, 2f, 3f);
var reordered = vector.GetZXY(); // (3, 1, 2)

// Insert a Y component: [x, y] becomes [x, 1, y].
var vector2 = new Vector2(2f, 3f);
var expanded = vector2.InsertY(1f); // (2, 1, 3)

// Negate only the X and Z components.
var partiallyNegated = vector.WithNegateXZ(); // (-1, 2, -3)

// Check whether all scale components are approximately equal.
var isUniform = transform.localScale.IsUniform();

// Find the closest point and its index in an array or IList<Vector3>.
var points = new[] { Vector3.zero, Vector3.right, Vector3.forward };
var closest = transform.position.GetClosestPoint(points);
Debug.Log($"Point: {closest.point}, index: {closest.index}");

// Reverse a ray from a point 10 units along its original direction.
var ray = new Ray(transform.position, transform.forward);
var reversed = ray.Reversed(10f);

// Randomly deflect the ray with yaw and pitch limits of 45 degrees.
var deflected = ray.WithRandomDeflection(45f);

// Return a color copy with new green and alpha channel values.
var color = Color.white.WithGA(1f, 0.5f);

// Map a value from one range to another without clamping.
var x = 0.25f;
var remapped = x.Remap(0f, 1f, 0f, 2f); // 0.5
```

Random selection, shuffling, and `MinBy`/`MaxBy` work on `IList<T>`, including arrays and `List<T>`. Use a resizable list for methods that remove elements:

```csharp
var numbers = new List<int> { 4, -7, 12, 1, 0 };

// Select elements without modifying the source list.
var element = numbers.GetRandom();
var elements = numbers.GetRandoms(3); // Three distinct positions, in source order.

// Use relative weights: hello = 30%, bye = 50%, ok = 20%.
var words = new[] { "hello", "bye", "ok" };
var random = words.GetRandomWithProbability(3f, 5f, 2f);
Debug.Log($"Word: {random.element}, index: {random.index}");

// Find extrema in a nonempty list; each result contains index and element.
var minimum = numbers.MinBy(value => value);
var maximum = numbers.MaxBy(value => value);
Debug.Log($"Minimum: {minimum.element} at {minimum.index}, maximum: {maximum.element} at {maximum.index}");

// Format any IEnumerable<T> for display.
Debug.Log(numbers.AsDisplayString()); // [4, -7, 12, 1, 0]

// Return a shuffled copy, or shuffle the source list in place.
var shuffled = numbers.Shuffled();
numbers.Shuffle();

// Remove and return the element at index 4.
var poppedElement = numbers.Pop(4);

// Remove two random elements; each tuple contains the element and its index before removal.
var poppedElements = numbers.PopRandoms(2);

// Remove all remaining elements from index 1 onward.
numbers.RemoveFrom(1);
```

And many other extensions! Read more on the <a href="https://github.com/KurbanismailovZaur/Extensions/wiki">wiki page</a>
