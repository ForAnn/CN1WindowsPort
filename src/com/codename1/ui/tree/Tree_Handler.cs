// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui.tree {
public class Tree_2Handler: global::java.lang.Object,global::com.codename1.ui.events.ActionListener {
private global::java.lang.Object _fcurrent;

public global::com.codename1.ui.tree.Tree _fthis_20;

public void @this(global::com.codename1.ui.tree.Tree n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.tree.Tree$Handler: void <init>(com.codename1.ui.tree.Tree)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::com.codename1.ui.tree.Tree_2Handler) _r0_o)._fthis_20 = (global::com.codename1.ui.tree.Tree) _r1_o;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.tree.Tree$Handler: void <init>(com.codename1.ui.tree.Tree)]
}

public void @this(global::com.codename1.ui.tree.Tree n1, global::java.lang.Object n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.tree.Tree$Handler: void <init>(com.codename1.ui.tree.Tree, java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    ((global::com.codename1.ui.tree.Tree_2Handler) _r0_o)._fthis_20 = (global::com.codename1.ui.tree.Tree) _r1_o;
    ((global::java.lang.Object) _r0_o).@this();
    ((global::com.codename1.ui.tree.Tree_2Handler) _r0_o)._fcurrent = (global::java.lang.Object) _r2_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.tree.Tree$Handler: void <init>(com.codename1.ui.tree.Tree, java.lang.Object)]
}

public virtual void actionPerformed(global::com.codename1.ui.events.ActionEvent n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.tree.Tree$Handler: void actionPerformed(com.codename1.ui.events.ActionEvent)]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r6_o = this;
    _r7_o = n1;
    _r3_o = ((global::com.codename1.ui.tree.Tree_2Handler) _r6_o)._fcurrent;
    if (_r3_o == null) goto label21;
    _r3_o = ((global::com.codename1.ui.tree.Tree_2Handler) _r6_o)._fthis_20;
    _r3_o = global::com.codename1.ui.tree.Tree.access_2000((global::com.codename1.ui.tree.Tree) _r3_o);
    _r4_o = new global::com.codename1.ui.events.ActionEvent();
    _r5_o = ((global::com.codename1.ui.tree.Tree_2Handler) _r6_o)._fcurrent;
    ((global::com.codename1.ui.events.ActionEvent) _r4_o).@this((global::java.lang.Object) _r5_o);
    ((global::com.codename1.ui.util.EventDispatcher) _r3_o).fireActionEvent((global::com.codename1.ui.events.ActionEvent) _r4_o);
    label20:;
    return;
    label21:;
    _r0_o = ((global::com.codename1.ui.events.ActionEvent) _r7_o).getSource();
    _r0_o = _r0_o;
    _r3_o = ((global::com.codename1.ui.Component) _r0_o).getParent();
    _r2_o = ((global::com.codename1.ui.Container) _r3_o).getLeadParent();
    if (_r2_o == null) goto label38;
    _r0_o = _r2_o;
    label38:;
    // Value=TREE_NODE_EXPANDED
    _r3_o = new global::java.lang.String();
    ((global::java.lang.String)_r3_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)84)), unchecked((char) unchecked((uint) 82)), unchecked((char) unchecked((uint) 69)), unchecked((char) unchecked((uint) 69)), unchecked((char) unchecked((uint) 95)), unchecked((char) unchecked((uint) 78)), unchecked((char) unchecked((uint) 79)), unchecked((char) unchecked((uint) 68)), unchecked((char) unchecked((uint) 69)), unchecked((char) unchecked((uint) 95)), unchecked((char) unchecked((uint) 69)), unchecked((char) unchecked((uint) 88)), unchecked((char) unchecked((uint) 80)), unchecked((char) unchecked((uint) 65)), unchecked((char) unchecked((uint) 78)), unchecked((char) unchecked((uint) 68)), unchecked((char) unchecked((uint) 69)), unchecked((char) unchecked((uint) 68))}));
    _r1_o = ((global::com.codename1.ui.Component) _r0_o).getClientProperty((global::java.lang.String) _r3_o);
    if (_r1_o == null) goto label60;
    // Value=true
    _r3_o = new global::java.lang.String();
    ((global::java.lang.String)_r3_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)116)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 101))}));
    _r3.i = ((global::java.lang.Object) _r1_o).equals((global::java.lang.Object) _r3_o) ? 1 : 0;
    if (_r3.i == 0) goto label60;
    _r3_o = ((global::com.codename1.ui.tree.Tree_2Handler) _r6_o)._fthis_20;
    global::com.codename1.ui.tree.Tree.access_2100((global::com.codename1.ui.tree.Tree) _r3_o, (global::com.codename1.ui.Component) _r0_o);
    goto label20;
    label60:;
    _r3_o = ((global::com.codename1.ui.tree.Tree_2Handler) _r6_o)._fthis_20;
    _r4_o = ((global::com.codename1.ui.tree.Tree_2Handler) _r6_o)._fthis_20;
    _r4.i = global::com.codename1.ui.tree.Tree.access_2200((global::com.codename1.ui.tree.Tree) _r4_o) ? 1 : 0;
    global::com.codename1.ui.tree.Tree.access_2300((global::com.codename1.ui.tree.Tree) _r3_o, 0!=_r4.i, (global::com.codename1.ui.Component) _r0_o);
    goto label20;
//XMLVM_END_WRAPPER[com.codename1.ui.tree.Tree$Handler: void actionPerformed(com.codename1.ui.events.ActionEvent)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.tree.Tree$Handler]
//XMLVM_END_WRAPPER[com.codename1.ui.tree.Tree$Handler]

} // end of class: Tree_2Handler

} // end of namespace: com.codename1.ui.tree
