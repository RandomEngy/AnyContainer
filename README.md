AnyContainer lets you write type registration code and static resolve code that's easily swappable to any number of IoC containers.

# How to use

### Register:
```c#
AnyContainerBase container = new SimpleInjectorAnyContainer();
container.RegisterSingleton<ILogger, Logger>();
container.RegisterTransient<ITransientService, TransientService>();
container.RegisterSingleton<IOtherService>(() => new OtherService("abc"));
```

### Setting up static resolver:
```c#
StaticResolver.SetResolver(container);
```

### Resolving from static context:
```c#
var logger = StaticResolver.Resolve<ILogger>();
```

For good design you should try to avoid doing a lot of static resolves and instead take the dependencies on the constructor. But sometimes it's still handy to be able to do it.

# Supported containers

* Simple Injector
* DryIoc
* Unity
