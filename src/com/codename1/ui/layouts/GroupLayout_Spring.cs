// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui.layouts {
public abstract class GroupLayout_2Spring: global::java.lang.Object {
private int _fsize;

private int _fmin;

private int _fmax;

private int _fpref;

private global::com.codename1.ui.layouts.GroupLayout_2Spring _fparent;

private int _falignment;

public global::com.codename1.ui.layouts.GroupLayout _fthis_20;

public void @this(global::com.codename1.ui.layouts.GroupLayout n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$Spring: void <init>(com.codename1.ui.layouts.GroupLayout)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    ((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r1_o)._fthis_20 = (global::com.codename1.ui.layouts.GroupLayout) _r2_o;
    ((global::java.lang.Object) _r1_o).@this();
    _r0.i = -2147483648;
    ((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r1_o)._fmax = _r0.i;
    ((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r1_o)._fpref = _r0.i;
    ((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r1_o)._fmin = _r0.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$Spring: void <init>(com.codename1.ui.layouts.GroupLayout)]
}

public abstract int calculateMinimumSize(int n1);

public abstract int calculatePreferredSize(int n1);

public abstract int calculateMaximumSize(int n1);

public virtual void setParent(global::com.codename1.ui.layouts.GroupLayout_2Spring n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$Spring: void setParent(com.codename1.ui.layouts.GroupLayout$Spring)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r0_o)._fparent = (global::com.codename1.ui.layouts.GroupLayout_2Spring) _r1_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$Spring: void setParent(com.codename1.ui.layouts.GroupLayout$Spring)]
}

public virtual global::System.Object getParent(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$Spring: com.codename1.ui.layouts.GroupLayout$Spring getParent()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r1_o)._fparent;
    return (global::com.codename1.ui.layouts.GroupLayout_2Spring) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$Spring: com.codename1.ui.layouts.GroupLayout$Spring getParent()]
}

public virtual void setAlignment(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$Spring: void setAlignment(int)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r0_o = this;
    _r1.i = n1;
    ((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r0_o)._falignment = _r1.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$Spring: void setAlignment(int)]
}

public virtual int getAlignment(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$Spring: int getAlignment()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r1_o)._falignment;
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$Spring: int getAlignment()]
}

public virtual int getMinimumSize(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$Spring: int getMinimumSize(int)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    _r2_o = this;
    _r3.i = n1;
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r2_o)._fmin;
    _r1.i = -2147483648;
    if (_r0.i != _r1.i) goto label16;
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r2_o).calculateMinimumSize((int) _r3.i);
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r2_o).constrain((int) _r0.i);
    ((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r2_o)._fmin = _r0.i;
    label16:;
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r2_o)._fmin;
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$Spring: int getMinimumSize(int)]
}

public virtual int getPreferredSize(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$Spring: int getPreferredSize(int)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    _r2_o = this;
    _r3.i = n1;
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r2_o)._fpref;
    _r1.i = -2147483648;
    if (_r0.i != _r1.i) goto label16;
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r2_o).calculatePreferredSize((int) _r3.i);
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r2_o).constrain((int) _r0.i);
    ((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r2_o)._fpref = _r0.i;
    label16:;
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r2_o)._fpref;
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$Spring: int getPreferredSize(int)]
}

public virtual int getMaximumSize(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$Spring: int getMaximumSize(int)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    _r2_o = this;
    _r3.i = n1;
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r2_o)._fmax;
    _r1.i = -2147483648;
    if (_r0.i != _r1.i) goto label16;
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r2_o).calculateMaximumSize((int) _r3.i);
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r2_o).constrain((int) _r0.i);
    ((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r2_o)._fmax = _r0.i;
    label16:;
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r2_o)._fmax;
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$Spring: int getMaximumSize(int)]
}

public virtual void unset(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$Spring: void unset()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = -2147483648;
    ((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r1_o)._fmax = _r0.i;
    ((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r1_o)._fpref = _r0.i;
    ((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r1_o)._fmin = _r0.i;
    ((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r1_o)._fsize = _r0.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$Spring: void unset()]
}

public virtual void setSize(int n1, int n2, int n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$Spring: void setSize(int, int, int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    _r1_o = this;
    _r2.i = n1;
    _r3.i = n2;
    _r4.i = n3;
    ((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r1_o)._fsize = _r4.i;
    _r0.i = -2147483648;
    if (_r4.i != _r0.i) goto label9;
    ((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r1_o).unset();
    label9:;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$Spring: void setSize(int, int, int)]
}

public virtual int getSize(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$Spring: int getSize()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r1_o)._fsize;
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$Spring: int getSize()]
}

public virtual int constrain(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$Spring: int constrain(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    _r1_o = this;
    _r2.i = n1;
    _r0.i = 32767;
    _r0.i = global::java.lang.Math.min((int) _r2.i, (int) _r0.i);
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$Spring: int constrain(int)]
}

public virtual int getBaseline(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$Spring: int getBaseline()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = -1;
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$Spring: int getBaseline()]
}

public virtual int getBaselineResizeBehavior(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$Spring: int getBaselineResizeBehavior()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = 4;
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$Spring: int getBaselineResizeBehavior()]
}

public virtual bool isResizable(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$Spring: boolean isResizable(int)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    _r3_o = this;
    _r4.i = n1;
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r3_o).getMinimumSize((int) _r4.i);
    _r1.i = ((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r3_o).getPreferredSize((int) _r4.i);
    if (_r0.i != _r1.i) goto label16;
    _r2.i = ((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r3_o).getMaximumSize((int) _r4.i);
    if (_r1.i == _r2.i) goto label18;
    label16:;
    _r2.i = 1;
    label17:;
    return _r2.i!=0;
    label18:;
    _r2.i = 0;
    goto label17;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$Spring: boolean isResizable(int)]
}

public abstract bool willHaveZeroSize(bool n1);

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$Spring]
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$Spring]

} // end of class: GroupLayout_2Spring

} // end of namespace: com.codename1.ui.layouts
