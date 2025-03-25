using Decorator;
using Decorator.Decorators;

IWrapee mage = new Mage();

mage = new ArtifactDecorator(mage, "Ancient book");

mage = new ClothesDecorator(mage, "Scarf");

mage = new AbilityDecorator(mage, "Meteor rain");

mage.SayHello();

mage.Attack();