// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui.list {
public class FilterProxyListModel_22: global::java.lang.Object,global::com.codename1.ui.events.DataChangedListener {
public global::com.codename1.ui.list.ContainerList _fval_2l;

public global::com.codename1.ui.TextField _fval_2search;

public static int _fREMOVED = com.codename1.ui.events._iDataChangedListener._fREMOVED;

public static int _fADDED = com.codename1.ui.events._iDataChangedListener._fADDED;

public static int _fCHANGED = com.codename1.ui.events._iDataChangedListener._fCHANGED;

public void @this(global::com.codename1.ui.list.ContainerList n1, global::com.codename1.ui.TextField n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.list.FilterProxyListModel$2: void <init>(com.codename1.ui.list.ContainerList, com.codename1.ui.TextField)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    ((global::com.codename1.ui.list.FilterProxyListModel_22) _r0_o)._fval_2l = (global::com.codename1.ui.list.ContainerList) _r1_o;
    ((global::com.codename1.ui.list.FilterProxyListModel_22) _r0_o)._fval_2search = (global::com.codename1.ui.TextField) _r2_o;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.list.FilterProxyListModel$2: void <init>(com.codename1.ui.list.ContainerList, com.codename1.ui.TextField)]
}

public virtual void dataChanged(int n1, int n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.list.FilterProxyListModel$2: void dataChanged(int, int)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    _r3_o = this;
    _r4.i = n1;
    _r5.i = n2;
    _r1_o = ((global::com.codename1.ui.list.FilterProxyListModel_22) _r3_o)._fval_2l;
    _r1_o = ((global::com.codename1.ui.list.ContainerList) _r1_o).getModel();
    _r1.i = ((_r1_o != null) && (_r1_o is global::com.codename1.ui.list.FilterProxyListModel)) ? 1 : 0;
    if (_r1.i == 0) goto label40;
    _r1_o = ((global::com.codename1.ui.list.FilterProxyListModel_22) _r3_o)._fval_2l;
    _r0_o = ((global::com.codename1.ui.list.ContainerList) _r1_o).getModel();
    _r0_o = _r0_o;
    label18:;
    _r1_o = ((global::com.codename1.ui.list.FilterProxyListModel_22) _r3_o)._fval_2search;
    _r1_o = ((global::com.codename1.ui.TextField) _r1_o).getText();
    _r1.i = ((global::java.lang.String) _r1_o).length();
    if (_r1.i != 0) goto label69;
    _r1_o = ((global::com.codename1.ui.list.FilterProxyListModel_22) _r3_o)._fval_2l;
    _r2_o = ((global::com.codename1.ui.list.FilterProxyListModel) _r0_o).getUnderlying();
    ((global::com.codename1.ui.list.ContainerList) _r1_o).setModel((global::com.codename1.ui.list.ListModel) _r2_o);
    label39:;
    return;
    label40:;
    _r1_o = ((global::com.codename1.ui.list.FilterProxyListModel_22) _r3_o)._fval_2search;
    _r1_o = ((global::com.codename1.ui.TextField) _r1_o).getText();
    _r1.i = ((global::java.lang.String) _r1_o).length();
    if (_r1.i == 0) goto label39;
    _r0_o = new global::com.codename1.ui.list.FilterProxyListModel();
    _r1_o = ((global::com.codename1.ui.list.FilterProxyListModel_22) _r3_o)._fval_2l;
    _r1_o = ((global::com.codename1.ui.list.ContainerList) _r1_o).getModel();
    ((global::com.codename1.ui.list.FilterProxyListModel) _r0_o).@this((global::com.codename1.ui.list.ListModel) _r1_o);
    _r1_o = ((global::com.codename1.ui.list.FilterProxyListModel_22) _r3_o)._fval_2l;
    ((global::com.codename1.ui.list.ContainerList) _r1_o).setModel((global::com.codename1.ui.list.ListModel) _r0_o);
    goto label18;
    label69:;
    _r1_o = ((global::com.codename1.ui.list.FilterProxyListModel_22) _r3_o)._fval_2search;
    _r1_o = ((global::com.codename1.ui.TextField) _r1_o).getText();
    ((global::com.codename1.ui.list.FilterProxyListModel) _r0_o).filter((global::java.lang.String) _r1_o);
    goto label39;
//XMLVM_END_WRAPPER[com.codename1.ui.list.FilterProxyListModel$2: void dataChanged(int, int)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.list.FilterProxyListModel$2]
//XMLVM_END_WRAPPER[com.codename1.ui.list.FilterProxyListModel$2]

} // end of class: FilterProxyListModel_22

} // end of namespace: com.codename1.ui.list
