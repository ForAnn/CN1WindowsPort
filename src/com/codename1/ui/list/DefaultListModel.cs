// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui.list {
public class DefaultListModel: global::java.lang.Object,global::com.codename1.ui.list.ListModel {
private global::java.util.List _fitems;

private global::com.codename1.ui.util.EventDispatcher _fdataListener;

private global::com.codename1.ui.util.EventDispatcher _fselectionListener;

private int _fselectedIndex;

public void @this(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.list.DefaultListModel: void <init>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    ((global::java.lang.Object) _r1_o).@this();
    _r0_o = new global::com.codename1.ui.util.EventDispatcher();
    ((global::com.codename1.ui.util.EventDispatcher) _r0_o).@this();
    ((global::com.codename1.ui.list.DefaultListModel) _r1_o)._fdataListener = (global::com.codename1.ui.util.EventDispatcher) _r0_o;
    _r0_o = new global::com.codename1.ui.util.EventDispatcher();
    ((global::com.codename1.ui.util.EventDispatcher) _r0_o).@this();
    ((global::com.codename1.ui.list.DefaultListModel) _r1_o)._fselectionListener = (global::com.codename1.ui.util.EventDispatcher) _r0_o;
    _r0.i = 0;
    ((global::com.codename1.ui.list.DefaultListModel) _r1_o)._fselectedIndex = _r0.i;
    _r0_o = new global::java.util.ArrayList();
    ((global::java.util.ArrayList) _r0_o).@this();
    ((global::com.codename1.ui.list.DefaultListModel) _r1_o)._fitems = (global::java.util.List) _r0_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.list.DefaultListModel: void <init>()]
}

public void @this(global::java.util.Vector n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.list.DefaultListModel: void <init>(java.util.Vector)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    ((global::java.lang.Object) _r1_o).@this();
    _r0_o = new global::com.codename1.ui.util.EventDispatcher();
    ((global::com.codename1.ui.util.EventDispatcher) _r0_o).@this();
    ((global::com.codename1.ui.list.DefaultListModel) _r1_o)._fdataListener = (global::com.codename1.ui.util.EventDispatcher) _r0_o;
    _r0_o = new global::com.codename1.ui.util.EventDispatcher();
    ((global::com.codename1.ui.util.EventDispatcher) _r0_o).@this();
    ((global::com.codename1.ui.list.DefaultListModel) _r1_o)._fselectionListener = (global::com.codename1.ui.util.EventDispatcher) _r0_o;
    _r0.i = 0;
    ((global::com.codename1.ui.list.DefaultListModel) _r1_o)._fselectedIndex = _r0.i;
    _r0_o = new global::java.util.ArrayList();
    ((global::java.util.ArrayList) _r0_o).@this((global::java.util.Collection) _r2_o);
    ((global::com.codename1.ui.list.DefaultListModel) _r1_o)._fitems = (global::java.util.List) _r0_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.list.DefaultListModel: void <init>(java.util.Vector)]
}

public void @this(global::java.util.Collection n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.list.DefaultListModel: void <init>(java.util.Collection)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    ((global::java.lang.Object) _r1_o).@this();
    _r0_o = new global::com.codename1.ui.util.EventDispatcher();
    ((global::com.codename1.ui.util.EventDispatcher) _r0_o).@this();
    ((global::com.codename1.ui.list.DefaultListModel) _r1_o)._fdataListener = (global::com.codename1.ui.util.EventDispatcher) _r0_o;
    _r0_o = new global::com.codename1.ui.util.EventDispatcher();
    ((global::com.codename1.ui.util.EventDispatcher) _r0_o).@this();
    ((global::com.codename1.ui.list.DefaultListModel) _r1_o)._fselectionListener = (global::com.codename1.ui.util.EventDispatcher) _r0_o;
    _r0.i = 0;
    ((global::com.codename1.ui.list.DefaultListModel) _r1_o)._fselectedIndex = _r0.i;
    _r0_o = new global::java.util.ArrayList();
    ((global::java.util.ArrayList) _r0_o).@this((global::java.util.Collection) _r2_o);
    ((global::com.codename1.ui.list.DefaultListModel) _r1_o)._fitems = (global::java.util.List) _r0_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.list.DefaultListModel: void <init>(java.util.Collection)]
}

public void @this(global::org.xmlvm._nArrayAdapter<global::System.Object> n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.list.DefaultListModel: void <init>(java.lang.Object[])]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    ((global::java.lang.Object) _r1_o).@this();
    _r0_o = new global::com.codename1.ui.util.EventDispatcher();
    ((global::com.codename1.ui.util.EventDispatcher) _r0_o).@this();
    ((global::com.codename1.ui.list.DefaultListModel) _r1_o)._fdataListener = (global::com.codename1.ui.util.EventDispatcher) _r0_o;
    _r0_o = new global::com.codename1.ui.util.EventDispatcher();
    ((global::com.codename1.ui.util.EventDispatcher) _r0_o).@this();
    ((global::com.codename1.ui.list.DefaultListModel) _r1_o)._fselectionListener = (global::com.codename1.ui.util.EventDispatcher) _r0_o;
    _r0.i = 0;
    ((global::com.codename1.ui.list.DefaultListModel) _r1_o)._fselectedIndex = _r0.i;
    _r0_o = global::com.codename1.ui.list.DefaultListModel.createList((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r2_o);
    ((global::com.codename1.ui.list.DefaultListModel) _r1_o)._fitems = (global::java.util.List) _r0_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.list.DefaultListModel: void <init>(java.lang.Object[])]
}

private static global::System.Object createList(global::org.xmlvm._nArrayAdapter<global::System.Object> n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.list.DefaultListModel: java.util.List createList(java.lang.Object[])]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r3_o = n1;
    if (_r3_o != null) goto label5;
    _r2.i = 0;
    _r3_o = new global::org.xmlvm._nArrayAdapter<global::System.Object>(new global::System.Object[_r2.i]);
    label5:;
    _r1_o = new global::java.util.ArrayList();
    _r2.i = ((global::org.xmlvm._nIArray) _r3_o).Length;
    ((global::java.util.ArrayList) _r1_o).@this((int) _r2.i);
    _r0.i = 0;
    label12:;
    _r2.i = ((global::org.xmlvm._nIArray) _r3_o).Length;
    if (_r0.i >= _r2.i) goto label23;
    _r2_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r3_o)[_r0.i];
    ((global::java.util.List) _r1_o).add((global::java.lang.Object) _r2_o);
    _r0.i = _r0.i + 1;
    goto label12;
    label23:;
    return (global::java.util.List) _r1_o;
//XMLVM_END_WRAPPER[com.codename1.ui.list.DefaultListModel: java.util.List createList(java.lang.Object[])]
}

public virtual global::System.Object getItemAt(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.list.DefaultListModel: java.lang.Object getItemAt(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2.i = n1;
    _r0.i = ((global::com.codename1.ui.list.DefaultListModel) _r1_o).getSize();
    if (_r2.i >= _r0.i) goto label15;
    if (_r2.i < 0) goto label15;
    _r0_o = ((global::com.codename1.ui.list.DefaultListModel) _r1_o)._fitems;
    _r0_o = ((global::java.util.List) _r0_o).get((int) _r2.i);
    label14:;
    return (global::java.lang.Object) _r0_o;
    label15:;
    _r0_o = null;
    goto label14;
//XMLVM_END_WRAPPER[com.codename1.ui.list.DefaultListModel: java.lang.Object getItemAt(int)]
}

public virtual int getSize(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.list.DefaultListModel: int getSize()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.ui.list.DefaultListModel) _r1_o)._fitems;
    _r0.i = ((global::java.util.List) _r0_o).size();
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.ui.list.DefaultListModel: int getSize()]
}

public virtual int getSelectedIndex(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.list.DefaultListModel: int getSelectedIndex()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0.i = ((global::com.codename1.ui.list.DefaultListModel) _r1_o)._fselectedIndex;
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.ui.list.DefaultListModel: int getSelectedIndex()]
}

public virtual void addItem(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.list.DefaultListModel: void addItem(java.lang.Object)]
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
    _r0_o = ((global::com.codename1.ui.list.DefaultListModel) _r2_o)._fitems;
    ((global::java.util.List) _r0_o).add((global::java.lang.Object) _r3_o);
    _r0.i = 1;
    _r1_o = ((global::com.codename1.ui.list.DefaultListModel) _r2_o)._fitems;
    _r1.i = ((global::java.util.List) _r1_o).size();
    ((global::com.codename1.ui.list.DefaultListModel) _r2_o).fireDataChangedEvent((int) _r0.i, (int) _r1.i);
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.list.DefaultListModel: void addItem(java.lang.Object)]
}

public virtual void setItem(int n1, global::java.lang.Object n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.list.DefaultListModel: void setItem(int, java.lang.Object)]
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
    _r0_o = ((global::com.codename1.ui.list.DefaultListModel) _r1_o)._fitems;
    ((global::java.util.List) _r0_o).set((int) _r2.i, (global::java.lang.Object) _r3_o);
    _r0.i = 2;
    ((global::com.codename1.ui.list.DefaultListModel) _r1_o).fireDataChangedEvent((int) _r0.i, (int) _r2.i);
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.list.DefaultListModel: void setItem(int, java.lang.Object)]
}

public virtual void addItemAtIndex(global::java.lang.Object n1, int n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.list.DefaultListModel: void addItemAtIndex(java.lang.Object, int)]
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
    _r3.i = n2;
    _r0_o = ((global::com.codename1.ui.list.DefaultListModel) _r1_o)._fitems;
    _r0.i = ((global::java.util.List) _r0_o).size();
    if (_r3.i > _r0.i) goto label17;
    _r0_o = ((global::com.codename1.ui.list.DefaultListModel) _r1_o)._fitems;
    ((global::java.util.List) _r0_o).add((int) _r3.i, (global::java.lang.Object) _r2_o);
    _r0.i = 1;
    ((global::com.codename1.ui.list.DefaultListModel) _r1_o).fireDataChangedEvent((int) _r0.i, (int) _r3.i);
    label17:;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.list.DefaultListModel: void addItemAtIndex(java.lang.Object, int)]
}

public virtual void removeItem(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.list.DefaultListModel: void removeItem(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2.i = n1;
    _r0.i = ((global::com.codename1.ui.list.DefaultListModel) _r1_o).getSize();
    if (_r2.i >= _r0.i) goto label25;
    if (_r2.i < 0) goto label25;
    _r0_o = ((global::com.codename1.ui.list.DefaultListModel) _r1_o)._fitems;
    ((global::java.util.List) _r0_o).remove((int) _r2.i);
    if (_r2.i == 0) goto label21;
    _r0.i = 1;
    _r0.i = _r2.i - _r0.i;
    ((global::com.codename1.ui.list.DefaultListModel) _r1_o).setSelectedIndex((int) _r0.i);
    label21:;
    _r0.i = 0;
    ((global::com.codename1.ui.list.DefaultListModel) _r1_o).fireDataChangedEvent((int) _r0.i, (int) _r2.i);
    label25:;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.list.DefaultListModel: void removeItem(int)]
}

public virtual void removeAll(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.list.DefaultListModel: void removeAll()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    label0:;
    _r0.i = ((global::com.codename1.ui.list.DefaultListModel) _r1_o).getSize();
    if (_r0.i <= 0) goto label11;
    _r0.i = 0;
    ((global::com.codename1.ui.list.DefaultListModel) _r1_o).removeItem((int) _r0.i);
    goto label0;
    label11:;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.list.DefaultListModel: void removeAll()]
}

public virtual void setSelectedIndex(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.list.DefaultListModel: void setSelectedIndex(int)]
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
    _r3_o = this;
    _r4.i = n1;
    _r0.i = ((global::com.codename1.ui.list.DefaultListModel) _r3_o)._fselectedIndex;
    ((global::com.codename1.ui.list.DefaultListModel) _r3_o)._fselectedIndex = _r4.i;
    _r1_o = ((global::com.codename1.ui.list.DefaultListModel) _r3_o)._fselectionListener;
    _r2.i = ((global::com.codename1.ui.list.DefaultListModel) _r3_o)._fselectedIndex;
    ((global::com.codename1.ui.util.EventDispatcher) _r1_o).fireSelectionEvent((int) _r0.i, (int) _r2.i);
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.list.DefaultListModel: void setSelectedIndex(int)]
}

public virtual void addDataChangedListener(global::com.codename1.ui.events.DataChangedListener n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.list.DefaultListModel: void addDataChangedListener(com.codename1.ui.events.DataChangedListener)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::com.codename1.ui.list.DefaultListModel) _r1_o)._fdataListener;
    ((global::com.codename1.ui.util.EventDispatcher) _r0_o).addListener((global::java.lang.Object) _r2_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.list.DefaultListModel: void addDataChangedListener(com.codename1.ui.events.DataChangedListener)]
}

public virtual void removeDataChangedListener(global::com.codename1.ui.events.DataChangedListener n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.list.DefaultListModel: void removeDataChangedListener(com.codename1.ui.events.DataChangedListener)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::com.codename1.ui.list.DefaultListModel) _r1_o)._fdataListener;
    ((global::com.codename1.ui.util.EventDispatcher) _r0_o).removeListener((global::java.lang.Object) _r2_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.list.DefaultListModel: void removeDataChangedListener(com.codename1.ui.events.DataChangedListener)]
}

public virtual void fireDataChangedEvent(int n1, int n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.list.DefaultListModel: void fireDataChangedEvent(int, int)]
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
    _r3.i = n2;
    _r0_o = ((global::com.codename1.ui.list.DefaultListModel) _r1_o)._fdataListener;
    ((global::com.codename1.ui.util.EventDispatcher) _r0_o).fireDataChangeEvent((int) _r3.i, (int) _r2.i);
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.list.DefaultListModel: void fireDataChangedEvent(int, int)]
}

public virtual void addSelectionListener(global::com.codename1.ui.events.SelectionListener n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.list.DefaultListModel: void addSelectionListener(com.codename1.ui.events.SelectionListener)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::com.codename1.ui.list.DefaultListModel) _r1_o)._fselectionListener;
    ((global::com.codename1.ui.util.EventDispatcher) _r0_o).addListener((global::java.lang.Object) _r2_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.list.DefaultListModel: void addSelectionListener(com.codename1.ui.events.SelectionListener)]
}

public virtual void removeSelectionListener(global::com.codename1.ui.events.SelectionListener n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.list.DefaultListModel: void removeSelectionListener(com.codename1.ui.events.SelectionListener)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::com.codename1.ui.list.DefaultListModel) _r1_o)._fselectionListener;
    ((global::com.codename1.ui.util.EventDispatcher) _r0_o).removeListener((global::java.lang.Object) _r2_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.list.DefaultListModel: void removeSelectionListener(com.codename1.ui.events.SelectionListener)]
}

public virtual global::System.Object getList(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.list.DefaultListModel: java.util.List getList()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.ui.list.DefaultListModel) _r1_o)._fitems;
    return (global::java.util.List) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.list.DefaultListModel: java.util.List getList()]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.list.DefaultListModel]
//XMLVM_END_WRAPPER[com.codename1.ui.list.DefaultListModel]

} // end of class: DefaultListModel

} // end of namespace: com.codename1.ui.list
