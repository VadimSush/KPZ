using Flyweight;

string content;

using (var client = new HttpClient())
{
    var response = await client.GetAsync("https://www.gutenberg.org/cache/epub/1513/pg1513.txt");
    content = await response.Content.ReadAsStringAsync();
}

string[] lineContent = content.Split('\n');

var body1 = new LightElementNodeParent("body", DisplayType.Block, []);

for (int i = 0; i < lineContent.Length; i++)
{
    var text = new LightTextNode(lineContent[i]);
    LightElementNodeParent res;
    if (i == 0)
    {
        res = new LightElementNodeParent("h1", DisplayType.Block, []);
    }
    else if (lineContent[i].StartsWith(" "))
    {
        res = new LightElementNodeParent("blockquote", DisplayType.Block, []);
    }
    else if (lineContent[i].Length < 20)
    {
        res = new LightElementNodeParent("h2", DisplayType.Block, []);
    }
    else
    {
        res = new LightElementNodeParent("p", DisplayType.Block, []);
    }
    res.AddNode(text);
    body1.AddNode(res);

}