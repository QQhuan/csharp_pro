1. 依赖属性

   wpf空间对象定义自定义属性，以便支持扩展，例如：可以自定义按钮的一个依赖属性，实现按钮被over、press等事件时的独特样式

2. 附加属性

   附加属性旨在用作可在任何对象上设置的一类全局属性

3. 路由事件

   其实就是事件在元素上的处理顺序，有隧道（下沉，事件以Preview开头）和冒泡两个过程。

4. xaml语法

   臃肿体系，编译成baml运行，后端使用C#实现逻辑交互

   语法：属性语法、属性元素语法、集合语法

   ```xaml
   <Button>
     <Button.Background>
       <SolidColorBrush Color="Blue"/>
     </Button.Background>
     <Button.Foreground>
       <SolidColorBrush Color="Red"/>
     </Button.Foreground>
     <Button.Content>
       属性元素语法
     </Button.Content>
   </Button>
   ```

   

   ```xaml
   <LinearGradientBrush>
     <LinearGradientBrush.GradientStops>
       <!-- 集合语法？ -->
       <GradientStop Offset="0.0" Color="Red" />
       <GradientStop Offset="1.0" Color="Blue" />
     </LinearGradientBrush.GradientStops>
   </LinearGradientBrush>
   ```

   模板：` <Setter Property="Template">  `，在模板内可以自由编写控件外观的扩展，比如渐变色、圆角等，同时可以通过`TemplateBinding`来绑定控件元素上的属性传值

   触发器：通过属性形式对样式进行设置，某个事件触发，样式自定义显示

   - 标记扩展
   - 

