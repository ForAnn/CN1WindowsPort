// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.components {
public class InteractionDialog: global::com.codename1.ui.Container {
private global::com.codename1.ui.Label _ftitle;

private global::com.codename1.ui.Container _ftitleArea;

private global::com.codename1.ui.Container _fcontentPane;

private bool _fanimateShow;

public void @this(){
//XMLVM_BEGIN_WRAPPER[com.codename1.components.InteractionDialog: void <init>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r0_o = new global::com.codename1.ui.layouts.BorderLayout();
    ((global::com.codename1.ui.layouts.BorderLayout) _r0_o).@this();
    ((global::com.codename1.ui.Container) _r2_o).@this((global::com.codename1.ui.layouts.Layout) _r0_o);
    _r0_o = new global::com.codename1.ui.Label();
    ((global::com.codename1.ui.Label) _r0_o).@this();
    ((global::com.codename1.components.InteractionDialog) _r2_o)._ftitle = (global::com.codename1.ui.Label) _r0_o;
    _r0_o = new global::com.codename1.ui.Container();
    _r1_o = new global::com.codename1.ui.layouts.BorderLayout();
    ((global::com.codename1.ui.layouts.BorderLayout) _r1_o).@this();
    ((global::com.codename1.ui.Container) _r0_o).@this((global::com.codename1.ui.layouts.Layout) _r1_o);
    ((global::com.codename1.components.InteractionDialog) _r2_o)._ftitleArea = (global::com.codename1.ui.Container) _r0_o;
    _r0_o = new global::com.codename1.ui.Container();
    ((global::com.codename1.ui.Container) _r0_o).@this();
    ((global::com.codename1.components.InteractionDialog) _r2_o)._fcontentPane = (global::com.codename1.ui.Container) _r0_o;
    _r0.i = 1;
    ((global::com.codename1.components.InteractionDialog) _r2_o)._fanimateShow = 0!=_r0.i;
    ((global::com.codename1.components.InteractionDialog) _r2_o).init();
    return;
//XMLVM_END_WRAPPER[com.codename1.components.InteractionDialog: void <init>()]
}

public void @this(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.components.InteractionDialog: void <init>(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r3_o = n1;
    _r0_o = new global::com.codename1.ui.layouts.BorderLayout();
    ((global::com.codename1.ui.layouts.BorderLayout) _r0_o).@this();
    ((global::com.codename1.ui.Container) _r2_o).@this((global::com.codename1.ui.layouts.Layout) _r0_o);
    _r0_o = new global::com.codename1.ui.Label();
    ((global::com.codename1.ui.Label) _r0_o).@this();
    ((global::com.codename1.components.InteractionDialog) _r2_o)._ftitle = (global::com.codename1.ui.Label) _r0_o;
    _r0_o = new global::com.codename1.ui.Container();
    _r1_o = new global::com.codename1.ui.layouts.BorderLayout();
    ((global::com.codename1.ui.layouts.BorderLayout) _r1_o).@this();
    ((global::com.codename1.ui.Container) _r0_o).@this((global::com.codename1.ui.layouts.Layout) _r1_o);
    ((global::com.codename1.components.InteractionDialog) _r2_o)._ftitleArea = (global::com.codename1.ui.Container) _r0_o;
    _r0_o = new global::com.codename1.ui.Container();
    ((global::com.codename1.ui.Container) _r0_o).@this();
    ((global::com.codename1.components.InteractionDialog) _r2_o)._fcontentPane = (global::com.codename1.ui.Container) _r0_o;
    _r0.i = 1;
    ((global::com.codename1.components.InteractionDialog) _r2_o)._fanimateShow = 0!=_r0.i;
    _r0_o = ((global::com.codename1.components.InteractionDialog) _r2_o)._ftitle;
    ((global::com.codename1.ui.Label) _r0_o).setText((global::java.lang.String) _r3_o);
    ((global::com.codename1.components.InteractionDialog) _r2_o).init();
    return;
//XMLVM_END_WRAPPER[com.codename1.components.InteractionDialog: void <init>(java.lang.String)]
}

private void init(){
//XMLVM_BEGIN_WRAPPER[com.codename1.components.InteractionDialog: void init()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r3_o = this;
    // Value=Center
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)67)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114))}));
    // Value=Dialog
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)68)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 103))}));
    ((global::com.codename1.components.InteractionDialog) _r3_o).setUIID((global::java.lang.String) _r0_o);
    _r0_o = ((global::com.codename1.components.InteractionDialog) _r3_o)._ftitle;
    // Value=DialogTitle
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)68)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 84)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101))}));
    ((global::com.codename1.ui.Label) _r0_o).setUIID((global::java.lang.String) _r1_o);
    _r0_o = ((global::com.codename1.components.InteractionDialog) _r3_o)._fcontentPane;
    // Value=DialogContentPane
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)68)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 67)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 80)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 101))}));
    ((global::com.codename1.ui.Container) _r0_o).setUIID((global::java.lang.String) _r1_o);
    // Value=North
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)78)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 104))}));
    _r1_o = ((global::com.codename1.components.InteractionDialog) _r3_o)._ftitleArea;
    base.addComponent((global::java.lang.Object) _r0_o, (global::com.codename1.ui.Component) _r1_o);
    _r0_o = ((global::com.codename1.components.InteractionDialog) _r3_o)._ftitleArea;
    // Value=Center
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)67)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114))}));
    _r1_o = ((global::com.codename1.components.InteractionDialog) _r3_o)._ftitle;
    ((global::com.codename1.ui.Container) _r0_o).addComponent((global::java.lang.Object) _r2_o, (global::com.codename1.ui.Component) _r1_o);
    // Value=Center
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)67)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114))}));
    _r0_o = ((global::com.codename1.components.InteractionDialog) _r3_o)._fcontentPane;
    base.addComponent((global::java.lang.Object) _r2_o, (global::com.codename1.ui.Component) _r0_o);
    _r0.i = 1;
    ((global::com.codename1.components.InteractionDialog) _r3_o).setGrabsPointerEvents(0!=_r0.i);
    return;
//XMLVM_END_WRAPPER[com.codename1.components.InteractionDialog: void init()]
}

public virtual global::System.Object getContentPane(){
//XMLVM_BEGIN_WRAPPER[com.codename1.components.InteractionDialog: com.codename1.ui.Container getContentPane()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.components.InteractionDialog) _r1_o)._fcontentPane;
    return (global::com.codename1.ui.Container) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.components.InteractionDialog: com.codename1.ui.Container getContentPane()]
}

public override void setScrollable(bool n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.components.InteractionDialog: void setScrollable(boolean)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2.i = n1 ? 1 : 0;
    _r0_o = ((global::com.codename1.components.InteractionDialog) _r1_o).getContentPane();
    ((global::com.codename1.ui.Container) _r0_o).setScrollable(0!=_r2.i);
    return;
//XMLVM_END_WRAPPER[com.codename1.components.InteractionDialog: void setScrollable(boolean)]
}

public override global::System.Object getLayout(){
//XMLVM_BEGIN_WRAPPER[com.codename1.components.InteractionDialog: com.codename1.ui.layouts.Layout getLayout()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.components.InteractionDialog) _r1_o)._fcontentPane;
    _r0_o = ((global::com.codename1.ui.Container) _r0_o).getLayout();
    return (global::com.codename1.ui.layouts.Layout) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.components.InteractionDialog: com.codename1.ui.layouts.Layout getLayout()]
}

public virtual global::System.Object getTitle(){
//XMLVM_BEGIN_WRAPPER[com.codename1.components.InteractionDialog: java.lang.String getTitle()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.components.InteractionDialog) _r1_o)._ftitle;
    _r0_o = ((global::com.codename1.ui.Label) _r0_o).getText();
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.components.InteractionDialog: java.lang.String getTitle()]
}

public override void addComponent(global::com.codename1.ui.Component n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.components.InteractionDialog: void addComponent(com.codename1.ui.Component)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::com.codename1.components.InteractionDialog) _r1_o)._fcontentPane;
    ((global::com.codename1.ui.Container) _r0_o).addComponent((global::com.codename1.ui.Component) _r2_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.components.InteractionDialog: void addComponent(com.codename1.ui.Component)]
}

public override void addComponent(global::java.lang.Object n1, global::com.codename1.ui.Component n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.components.InteractionDialog: void addComponent(java.lang.Object, com.codename1.ui.Component)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    _r3_o = n2;
    _r0_o = ((global::com.codename1.components.InteractionDialog) _r1_o)._fcontentPane;
    ((global::com.codename1.ui.Container) _r0_o).addComponent((global::java.lang.Object) _r2_o, (global::com.codename1.ui.Component) _r3_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.components.InteractionDialog: void addComponent(java.lang.Object, com.codename1.ui.Component)]
}

public override void addComponent(int n1, global::java.lang.Object n2, global::com.codename1.ui.Component n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.components.InteractionDialog: void addComponent(int, java.lang.Object, com.codename1.ui.Component)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2.i = n1;
    _r3_o = n2;
    _r4_o = n3;
    _r0_o = ((global::com.codename1.components.InteractionDialog) _r1_o)._fcontentPane;
    ((global::com.codename1.ui.Container) _r0_o).addComponent((int) _r2.i, (global::java.lang.Object) _r3_o, (global::com.codename1.ui.Component) _r4_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.components.InteractionDialog: void addComponent(int, java.lang.Object, com.codename1.ui.Component)]
}

public override void addComponent(int n1, global::com.codename1.ui.Component n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.components.InteractionDialog: void addComponent(int, com.codename1.ui.Component)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2.i = n1;
    _r3_o = n2;
    _r0_o = ((global::com.codename1.components.InteractionDialog) _r1_o)._fcontentPane;
    ((global::com.codename1.ui.Container) _r0_o).addComponent((int) _r2.i, (global::com.codename1.ui.Component) _r3_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.components.InteractionDialog: void addComponent(int, com.codename1.ui.Component)]
}

public override void removeAll(){
//XMLVM_BEGIN_WRAPPER[com.codename1.components.InteractionDialog: void removeAll()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.components.InteractionDialog) _r1_o)._fcontentPane;
    ((global::com.codename1.ui.Container) _r0_o).removeAll();
    return;
//XMLVM_END_WRAPPER[com.codename1.components.InteractionDialog: void removeAll()]
}

public override void removeComponent(global::com.codename1.ui.Component n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.components.InteractionDialog: void removeComponent(com.codename1.ui.Component)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::com.codename1.components.InteractionDialog) _r1_o)._fcontentPane;
    ((global::com.codename1.ui.Container) _r0_o).removeComponent((global::com.codename1.ui.Component) _r2_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.components.InteractionDialog: void removeComponent(com.codename1.ui.Component)]
}

public virtual global::System.Object getTitleComponent(){
//XMLVM_BEGIN_WRAPPER[com.codename1.components.InteractionDialog: com.codename1.ui.Label getTitleComponent()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.components.InteractionDialog) _r1_o)._ftitle;
    return (global::com.codename1.ui.Label) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.components.InteractionDialog: com.codename1.ui.Label getTitleComponent()]
}

public override void setLayout(global::com.codename1.ui.layouts.Layout n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.components.InteractionDialog: void setLayout(com.codename1.ui.layouts.Layout)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::com.codename1.components.InteractionDialog) _r1_o)._fcontentPane;
    ((global::com.codename1.ui.Container) _r0_o).setLayout((global::com.codename1.ui.layouts.Layout) _r2_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.components.InteractionDialog: void setLayout(com.codename1.ui.layouts.Layout)]
}

public virtual void setTitle(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.components.InteractionDialog: void setTitle(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::com.codename1.components.InteractionDialog) _r1_o)._ftitle;
    ((global::com.codename1.ui.Label) _r0_o).setText((global::java.lang.String) _r2_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.components.InteractionDialog: void setTitle(java.lang.String)]
}

public virtual void show(int n1, int n2, int n3, int n4){
//XMLVM_BEGIN_WRAPPER[com.codename1.components.InteractionDialog: void show(int, int, int, int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r5_o = null;
    global::org.xmlvm._nElement _r6;
    global::System.Object _r6_o = null;
    global::org.xmlvm._nElement _r7;
    global::System.Object _r7_o = null;
    global::org.xmlvm._nElement _r8;
    global::System.Object _r8_o = null;
    global::org.xmlvm._nElement _r9;
    global::System.Object _r9_o = null;
    global::org.xmlvm._nElement _r10;
    global::System.Object _r10_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r6_o = this;
    _r7.i = n1;
    _r8.i = n2;
    _r9.i = n3;
    _r10.i = n4;
    _r5.i = 1;
    _r3_o = global::com.codename1.ui.Display.getInstance();
    _r0_o = ((global::com.codename1.ui.Display) _r3_o).getCurrent();
    _r3_o = ((global::com.codename1.ui.Form) _r0_o).getLayeredPane();
    _r4_o = new global::com.codename1.ui.layouts.BorderLayout();
    ((global::com.codename1.ui.layouts.BorderLayout) _r4_o).@this();
    ((global::com.codename1.ui.Container) _r3_o).setLayout((global::com.codename1.ui.layouts.Layout) _r4_o);
    _r3_o = ((global::com.codename1.components.InteractionDialog) _r6_o).getUnselectedStyle();
    _r4.i = 0;
    ((global::com.codename1.ui.plaf.Style) _r3_o).setMargin((int) _r4.i, (int) _r7.i);
    _r3_o = ((global::com.codename1.components.InteractionDialog) _r6_o).getUnselectedStyle();
    _r4.i = 2;
    ((global::com.codename1.ui.plaf.Style) _r3_o).setMargin((int) _r4.i, (int) _r8.i);
    _r3_o = ((global::com.codename1.components.InteractionDialog) _r6_o).getUnselectedStyle();
    ((global::com.codename1.ui.plaf.Style) _r3_o).setMargin((int) _r5.i, (int) _r9.i);
    _r3_o = ((global::com.codename1.components.InteractionDialog) _r6_o).getUnselectedStyle();
    _r4.i = 3;
    ((global::com.codename1.ui.plaf.Style) _r3_o).setMargin((int) _r4.i, (int) _r10.i);
    _r3_o = ((global::com.codename1.components.InteractionDialog) _r6_o).getUnselectedStyle();
    _r4.i = 4;
    _r4_o = new global::org.xmlvm._nArrayAdapter<sbyte>(new sbyte[_r4.i]);
    _r4_o = new global::org.xmlvm._nArrayAdapter<sbyte>(new sbyte[]{0, 0, 0, 0});
    ((global::com.codename1.ui.plaf.Style) _r3_o).setMarginUnit((global::org.xmlvm._nArrayAdapter<sbyte>) _r4_o);
    _r3_o = ((global::com.codename1.ui.Form) _r0_o).getLayeredPane();
    // Value=Center
    _r4_o = new global::java.lang.String();
    ((global::java.lang.String)_r4_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)67)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114))}));
    ((global::com.codename1.ui.Container) _r3_o).addComponent((global::java.lang.Object) _r4_o, (global::com.codename1.ui.Component) _r6_o);
    _r3.i = ((global::com.codename1.components.InteractionDialog) _r6_o)._fanimateShow ? 1 : 0;
    if (_r3.i == 0) goto label120;
    _r3.i = ((global::com.codename1.ui.Form) _r0_o).getWidth();
    _r3.i = _r3.i - _r10.i;
    _r3.i = _r3.i - _r9.i;
    _r3.i = _r3.i / 2;
    _r1.i = _r9.i + _r3.i;
    _r3.i = ((global::com.codename1.ui.Form) _r0_o).getHeight();
    _r3.i = _r3.i - _r8.i;
    _r3.i = _r3.i - _r7.i;
    _r3.i = _r3.i / 2;
    _r2.i = _r7.i + _r3.i;
    ((global::com.codename1.components.InteractionDialog) _r6_o).setX((int) _r1.i);
    ((global::com.codename1.components.InteractionDialog) _r6_o).setY((int) _r2.i);
    ((global::com.codename1.components.InteractionDialog) _r6_o).setWidth((int) _r5.i);
    ((global::com.codename1.components.InteractionDialog) _r6_o).setHeight((int) _r5.i);
    _r3_o = ((global::com.codename1.ui.Form) _r0_o).getLayeredPane();
    _r4.i = 400;
    ((global::com.codename1.ui.Container) _r3_o).animateLayout((int) _r4.i);
    label119:;
    return;
    label120:;
    _r3_o = ((global::com.codename1.ui.Form) _r0_o).getLayeredPane();
    ((global::com.codename1.ui.Container) _r3_o).revalidate();
    goto label119;
    label128:;
//XMLVM_END_WRAPPER[com.codename1.components.InteractionDialog: void show(int, int, int, int)]
}

public virtual void dispose(){
//XMLVM_BEGIN_WRAPPER[com.codename1.components.InteractionDialog: void dispose()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r4_o = this;
    _r3.i = 1;
    _r0_o = ((global::com.codename1.components.InteractionDialog) _r4_o).getParent();
    if (_r0_o == null) goto label58;
    _r1.i = ((global::com.codename1.components.InteractionDialog) _r4_o)._fanimateShow ? 1 : 0;
    if (_r1.i == 0) goto label52;
    _r1.i = ((global::com.codename1.components.InteractionDialog) _r4_o).getX();
    _r2.i = ((global::com.codename1.components.InteractionDialog) _r4_o).getWidth();
    _r2.i = _r2.i / 2;
    _r1.i = _r1.i + _r2.i;
    ((global::com.codename1.components.InteractionDialog) _r4_o).setX((int) _r1.i);
    _r1.i = ((global::com.codename1.components.InteractionDialog) _r4_o).getY();
    _r2.i = ((global::com.codename1.components.InteractionDialog) _r4_o).getHeight();
    _r2.i = _r2.i / 2;
    _r1.i = _r1.i + _r2.i;
    ((global::com.codename1.components.InteractionDialog) _r4_o).setY((int) _r1.i);
    ((global::com.codename1.components.InteractionDialog) _r4_o).setWidth((int) _r3.i);
    ((global::com.codename1.components.InteractionDialog) _r4_o).setHeight((int) _r3.i);
    _r1.i = 400;
    _r2.i = 100;
    ((global::com.codename1.ui.Container) _r0_o).animateUnlayoutAndWait((int) _r1.i, (int) _r2.i);
    label52:;
    ((global::com.codename1.ui.Container) _r0_o).removeComponent((global::com.codename1.ui.Component) _r4_o);
    ((global::com.codename1.ui.Container) _r0_o).revalidate();
    label58:;
    return;
//XMLVM_END_WRAPPER[com.codename1.components.InteractionDialog: void dispose()]
}

public virtual bool isShowing(){
//XMLVM_BEGIN_WRAPPER[com.codename1.components.InteractionDialog: boolean isShowing()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.components.InteractionDialog) _r1_o).getParent();
    if (_r0_o == null) goto label8;
    _r0.i = 1;
    label7:;
    return _r0.i!=0;
    label8:;
    _r0.i = 0;
    goto label7;
//XMLVM_END_WRAPPER[com.codename1.components.InteractionDialog: boolean isShowing()]
}

public virtual bool isAnimateShow(){
//XMLVM_BEGIN_WRAPPER[com.codename1.components.InteractionDialog: boolean isAnimateShow()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0.i = ((global::com.codename1.components.InteractionDialog) _r1_o)._fanimateShow ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[com.codename1.components.InteractionDialog: boolean isAnimateShow()]
}

public virtual void setAnimateShow(bool n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.components.InteractionDialog: void setAnimateShow(boolean)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1.i = n1 ? 1 : 0;
    ((global::com.codename1.components.InteractionDialog) _r0_o)._fanimateShow = 0!=_r1.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.components.InteractionDialog: void setAnimateShow(boolean)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.components.InteractionDialog]
//XMLVM_END_WRAPPER[com.codename1.components.InteractionDialog]

} // end of class: InteractionDialog

} // end of namespace: com.codename1.components
