# Link
System.Reflection.ReflectionTypeLoadException: 无法加载一个或多个请求的类型。有关更多信息，请检索 LoaderExceptions 属性。
反射代码的时候，碰到一个如题的错误。

主要原因是你所需要通过反射载入的代码还依赖其他的代码，而你却没有提供（放入相关的文件夹）。比如A继承B，你需要载入A，却忘记复制B所在的dll去相关目录。所以只要把dll提供齐全就好了。

<img  src="https://github.com/naiop/Link/blob/master/img/zs.png"  width="60%" />
