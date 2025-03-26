using Observer;

Publisher publisher = new Publisher();

LightElementNode p = new LightElementNode("p", LightElementNode.DisplayType.Block, [], publisher: publisher);

p.AddMouseEventListener("click", (int x, int y) =>
{
    Console.WriteLine($"Click x: {x}, y: {y}");
    p.classList.Add("p-clicked");
});

Console.WriteLine(p.GetOuterHTML());
publisher.NotifyClick(10, 20);
Console.WriteLine(p.GetOuterHTML());