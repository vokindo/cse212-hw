using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue multiple items with the same priority.
    // Expected Result: The first one inserted should be dequeued (FIFO).
    // Defect(s) Found: Method uses >= instead of > so it returns last equal item.
    public void TestPriorityQueue_1()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("A", 3);
        pq.Enqueue("B", 3);
        pq.Enqueue("C", 3);

        var result = pq.Dequeue();
        Assert.AreEqual("A", result); // FIFO: A should come out first
    }

    [TestMethod]
    // Scenario: Enqueue items with different priorities.
    // Expected Result: Item with highest priority (10) is returned.
    // Defect(s) Found: Method did not remove item from list after dequeue.
    public void TestPriorityQueue_2()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("Low", 1);
        pq.Enqueue("Medium", 5);
        pq.Enqueue("High", 10);

        var result = pq.Dequeue();
        Assert.AreEqual("High", result); // Highest priority
    }

    [TestMethod]
    // Scenario: Enqueue several items, Dequeue multiple times.
    // Expected Result: Items come out in correct order by priority and FIFO tie-breaker.
    // Defect(s) Found: Items were not being removed from queue.
    public void TestPriorityQueue_MultipleDequeues()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("X", 3);
        pq.Enqueue("Y", 4);
        pq.Enqueue("Z", 4);

        Assert.AreEqual("Y", pq.Dequeue());
        Assert.AreEqual("Z", pq.Dequeue());
        Assert.AreEqual("X", pq.Dequeue());
    }

    [TestMethod]
    // Scenario: Dequeue from an empty queue.
    // Expected Result: InvalidOperationException with correct message.
    // Defect(s) Found: None.
    public void TestPriorityQueue_Empty()
    {
        var pq = new PriorityQueue();

        try
        {
            pq.Dequeue();
            Assert.Fail("Expected exception not thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
    }
}
