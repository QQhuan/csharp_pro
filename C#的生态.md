1. win32，使用C\C++开发的，可以直接操作底层硬件、使用资源，灵活且强大，具有更高的兼容性和功能自由度。

2. MFC对win32的简单封装

3. winform，基于.net，相当于.net版本的MFC，UI相对简陋，代码相对复杂

4. **WPF**，开创MVVM设计模式，xaml标记语言

5. UWP，universal windows platform也是桌面应用程序开发框架，起初微软对uwp的期望是做一套统一的界面风格和用户体验，期望一次开发可以全平台使用，但是拉垮了。

   uwp的win ui2 控件库（通过Nuget安装）和操作系统和windows SDK紧密耦合，但是又极大限制对系统资源的访问。

6. windows app SDK，又名 project reunion，是一组新的开发组件和工具，号称代表未来的发展，MISX打包部署。

   其中的winUI 3，与windows SDK解耦合，其实是跨平台框架MAUI的桌面实现，可以开发安卓和iOS应用。可以使用**fluent design system**的UI组件库。

- winUI2 、3都只支持win10 1809及之后的版本，winui2于2018年发布，winui3与2020年发布