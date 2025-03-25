using Decorator;
using Decorator.Decorators;

IWrapee mage = new Mage();

mage = new ArtefactDecorator(mage, "Ancient book");

mage = new ClothesDecorator(mage, "Scarf");

mage = new AbilityDecorator(mage, "Meteor rain");

mage.SayHello();

mage.Attack();