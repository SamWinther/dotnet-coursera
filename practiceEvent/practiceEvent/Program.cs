// See https://aka.ms/new-console-template for more information
using practiceEvent;

EventExample myevent = new EventExample();
Subscriber mySubscribe = new Subscriber();

myevent.TaskFinish += mySubscribe.SubscriberMethod;

myevent.ActionMaker("for now");

