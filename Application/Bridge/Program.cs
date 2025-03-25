using Bridge.Abstractions;
using Bridge.Implementations;

Shape circle = new Circle();

Shape triangle = new Triangle();

Canvas vectorCanvas = new VectorCanvas(circle);

Canvas pixelsCanvas = new PixelsCanvas(triangle);

vectorCanvas.Draw();
pixelsCanvas.Draw();