using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Low", 1);
        priorityQueue.Enqueue("Medium", 5);
        priorityQueue.Enqueue("High", 10);

        string result = priorityQueue.Dequeue();
        Assert.AreEqual("High", result);
        //Assert.Fail("Implement the test case and then remove this.");
    }

    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 5);
        priorityQueue.Enqueue("B", 10);
        priorityQueue.Enqueue("C", 10); // Same priority as B, but B inserted first

        string result = priorityQueue.Dequeue();
        Assert.AreEqual("C", result);
        //Assert.Fail("Implement the test case and then remove this.");
    }

    // Add more test cases as needed below.
    public void Enqueue_MultipleItemsWithDescendingPriority_ReturnsCorrectOrder()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("First", 1);
        pq.Enqueue("Second", 2);
        pq.Enqueue("Third", 3);

        Assert.AreEqual("Third", pq.Dequeue()); // Highest priority first
        Assert.AreEqual("Second", pq.Dequeue()); // Then second highest
        Assert.AreEqual("First", pq.Dequeue()); // Then lowest
    }

    
    public void Enqueue_SingleItem_ReturnsThatItem()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("OnlyOne", 99);
        string result = pq.Dequeue();
        Assert.AreEqual("OnlyOne", result);
    }

}