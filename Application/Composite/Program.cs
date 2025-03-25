using Composite;

LightElementNode table = new LightElementNode("table", LightElementNode.DisplayType.Block, ["table-red", "table-main"]);

LightElementNode tr1 = new LightElementNode("tr", LightElementNode.DisplayType.Block, []);
LightElementNode td1 = new LightElementNode("td", LightElementNode.DisplayType.Block, []);
LightTextNode text1 = new LightTextNode("Text in td1");

td1.AddNode(text1);

LightElementNode td2 = new LightElementNode("td", LightElementNode.DisplayType.Block, [], [], LightElementNode.ClosureType.Single);

tr1.AddNode(td1);
tr1.AddNode(td2);

LightElementNode tr2 = new LightElementNode("tr", LightElementNode.DisplayType.Block, []);
LightElementNode td3 = new LightElementNode("td", LightElementNode.DisplayType.Block, []);
LightTextNode text3 = new LightTextNode("Text in td3");

td3.AddNode(text3);

LightElementNode td4 = new LightElementNode("td", LightElementNode.DisplayType.Block, []);
LightElementNode p = new LightElementNode("p", LightElementNode.DisplayType.Block, []);
LightTextNode text4 = new LightTextNode("Text in p");

p.AddNode(text4);
td4.AddNode(p);

tr2.AddNode(td3);
tr2.AddNode(td4);

table.AddNode(tr1);
table.AddNode(tr2);

Console.WriteLine(table.GetContents());