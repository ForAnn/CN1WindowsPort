// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui.table {
public class Table_2Listener: global::java.lang.Object,global::com.codename1.ui.events.DataChangedListener,global::com.codename1.ui.events.ActionListener {
private int _feditingColumn;

private int _feditingRow;

public global::com.codename1.ui.table.Table _fthis_20;

public static int _fREMOVED = com.codename1.ui.events._iDataChangedListener._fREMOVED;

public static int _fADDED = com.codename1.ui.events._iDataChangedListener._fADDED;

public static int _fCHANGED = com.codename1.ui.events._iDataChangedListener._fCHANGED;

public void @this(global::com.codename1.ui.table.Table n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.table.Table$Listener: void <init>(com.codename1.ui.table.Table)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    _r0.i = -1;
    ((global::com.codename1.ui.table.Table_2Listener) _r1_o)._fthis_20 = (global::com.codename1.ui.table.Table) _r2_o;
    ((global::java.lang.Object) _r1_o).@this();
    ((global::com.codename1.ui.table.Table_2Listener) _r1_o)._feditingColumn = _r0.i;
    ((global::com.codename1.ui.table.Table_2Listener) _r1_o)._feditingRow = _r0.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.table.Table$Listener: void <init>(com.codename1.ui.table.Table)]
}

public virtual void dataChanged(int n1, int n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.table.Table$Listener: void dataChanged(int, int)]
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
    _r8_o = this;
    _r9.i = n1;
    _r10.i = n2;
    _r7.i = -1;
    _r6.i = ((global::com.codename1.ui.table.Table_2Listener) _r8_o)._feditingColumn;
    if (_r6.i != _r10.i) goto label14;
    _r6.i = ((global::com.codename1.ui.table.Table_2Listener) _r8_o)._feditingRow;
    if (_r6.i != _r9.i) goto label14;
    ((global::com.codename1.ui.table.Table_2Listener) _r8_o)._feditingColumn = _r7.i;
    ((global::com.codename1.ui.table.Table_2Listener) _r8_o)._feditingRow = _r7.i;
    label13:;
    return;
    label14:;
    _r6_o = ((global::com.codename1.ui.table.Table_2Listener) _r8_o)._fthis_20;
    _r6_o = global::com.codename1.ui.table.Table.access_2000((global::com.codename1.ui.table.Table) _r6_o);
    _r5_o = ((global::com.codename1.ui.table.TableModel) _r6_o).getValueAt((int) _r9.i, (int) _r10.i);
    _r6_o = ((global::com.codename1.ui.table.Table_2Listener) _r8_o)._fthis_20;
    _r6_o = global::com.codename1.ui.table.Table.access_2000((global::com.codename1.ui.table.Table) _r6_o);
    _r3.i = ((global::com.codename1.ui.table.TableModel) _r6_o).isCellEditable((int) _r9.i, (int) _r10.i) ? 1 : 0;
    _r6_o = ((global::com.codename1.ui.table.Table_2Listener) _r8_o)._fthis_20;
    _r1_o = global::com.codename1.ui.table.Table.access_2100((global::com.codename1.ui.table.Table) _r6_o, (global::java.lang.Object) _r5_o, (int) _r9.i, (int) _r10.i, 0!=_r3.i);
    _r6_o = ((global::com.codename1.ui.table.Table_2Listener) _r8_o)._fthis_20;
    _r4_o = ((global::com.codename1.ui.table.Table) _r6_o).getLayout();
    _r4_o = _r4_o;
    _r6_o = ((global::com.codename1.ui.table.Table_2Listener) _r8_o)._fthis_20;
    _r2_o = ((global::com.codename1.ui.table.Table) _r6_o).createCellConstraint((global::java.lang.Object) _r5_o, (int) _r9.i, (int) _r10.i);
    _r6_o = ((global::com.codename1.ui.table.Table_2Listener) _r8_o)._fthis_20;
    _r6.i = global::com.codename1.ui.table.Table.access_2200((global::com.codename1.ui.table.Table) _r6_o) ? 1 : 0;
    if (_r6.i == 0) goto label64;
    _r9.i = _r9.i + 1;
    label64:;
    _r0_o = ((global::com.codename1.ui.table.TableLayout) _r4_o).getComponentAt((int) _r9.i, (int) _r10.i);
    _r6_o = ((global::com.codename1.ui.table.Table_2Listener) _r8_o)._fthis_20;
    ((global::com.codename1.ui.table.Table) _r6_o).removeComponent((global::com.codename1.ui.Component) _r0_o);
    _r6.i = 0;
    ((global::com.codename1.ui.Component) _r0_o).setVisible(0!=_r6.i);
    _r6_o = ((global::com.codename1.ui.table.Table_2Listener) _r8_o)._fthis_20;
    ((global::com.codename1.ui.table.Table) _r6_o).addComponent((global::java.lang.Object) _r2_o, (global::com.codename1.ui.Component) _r1_o);
    _r6_o = ((global::com.codename1.ui.table.Table_2Listener) _r8_o)._fthis_20;
    ((global::com.codename1.ui.table.Table) _r6_o).layoutContainer();
    ((global::com.codename1.ui.Component) _r1_o).requestFocus();
    _r6_o = ((global::com.codename1.ui.table.Table_2Listener) _r8_o)._fthis_20;
    ((global::com.codename1.ui.table.Table) _r6_o).revalidate();
    goto label13;
//XMLVM_END_WRAPPER[com.codename1.ui.table.Table$Listener: void dataChanged(int, int)]
}

public virtual void actionPerformed(global::com.codename1.ui.events.ActionEvent n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.table.Table$Listener: void actionPerformed(com.codename1.ui.events.ActionEvent)]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r5_o = this;
    _r6_o = n1;
    _r2_o = ((global::com.codename1.ui.events.ActionEvent) _r6_o).getSource();
    _r2_o = _r2_o;
    _r3_o = ((global::com.codename1.ui.table.Table_2Listener) _r5_o)._fthis_20;
    _r1.i = ((global::com.codename1.ui.table.Table) _r3_o).getCellRow((global::com.codename1.ui.Component) _r2_o);
    _r3_o = ((global::com.codename1.ui.table.Table_2Listener) _r5_o)._fthis_20;
    _r0.i = ((global::com.codename1.ui.table.Table) _r3_o).getCellColumn((global::com.codename1.ui.Component) _r2_o);
    ((global::com.codename1.ui.table.Table_2Listener) _r5_o)._feditingColumn = _r0.i;
    ((global::com.codename1.ui.table.Table_2Listener) _r5_o)._feditingRow = _r1.i;
    _r3_o = ((global::com.codename1.ui.table.Table_2Listener) _r5_o)._fthis_20;
    _r3_o = ((global::com.codename1.ui.table.Table) _r3_o).getModel();
    _r4_o = ((global::com.codename1.ui.TextArea) _r2_o).getText();
    ((global::com.codename1.ui.table.TableModel) _r3_o).setValueAt((int) _r1.i, (int) _r0.i, (global::java.lang.Object) _r4_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.table.Table$Listener: void actionPerformed(com.codename1.ui.events.ActionEvent)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.table.Table$Listener]
//XMLVM_END_WRAPPER[com.codename1.ui.table.Table$Listener]

} // end of class: Table_2Listener

} // end of namespace: com.codename1.ui.table
