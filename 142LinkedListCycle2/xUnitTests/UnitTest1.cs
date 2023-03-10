using _142LinkedListCycle2;

namespace _142LinkedListCycle2UnitTests;

public class UnitTest1
{
    public static IEnumerable<object[]> CycleTestData()
    {
        ListNode[] nodes1 = new ListNode[] {
            new ListNode(3),
            new ListNode(2),
            new ListNode(0),
            new ListNode(-4)
        };
        nodes1[0].next = nodes1[1];
        nodes1[1].next = nodes1[2];
        nodes1[2].next = nodes1[3];
        yield return new object[] { nodes1, -1 };

        ListNode[] nodes2 = new ListNode[] {
            new ListNode(1)
        };
        yield return new object[] { nodes2, -1 };

        ListNode[] nodes3 = new ListNode[] {
            new ListNode(1),
            new ListNode(2)
        };
        nodes3[0].next = nodes3[1];
        nodes3[1].next = nodes3[0];
        yield return new object[] { nodes3, 0 };

        ListNode[] nodes4 = new ListNode[] {
            new ListNode(1),
            new ListNode(2),
            new ListNode(3),
            new ListNode(4)
        };
        nodes4[0].next = nodes4[1];
        nodes4[1].next = nodes4[2];
        nodes4[2].next = nodes4[3];
        nodes4[3].next = nodes4[1];
        yield return new object[] { nodes4, 1 };
    }
    
    [Theory]
    [MemberData(nameof(CycleTestData))]
    public void Test1(ListNode[] nodes, int cycleStart)
    {
        // Arrange
        ListNode head = nodes[0];
        ListNode tail = nodes[nodes.Length - 1];
        if (cycleStart >= 0) tail.next = nodes[cycleStart];

        // Act
        Solution solution = new Solution();
        ListNode result = solution.DetectCycle(head);

        // Assert
        if (cycleStart >= 0)
        {
            Assert.Equal(nodes[cycleStart], result);
        }
        else
        {
            Assert.Null(result);
        }
    }
}