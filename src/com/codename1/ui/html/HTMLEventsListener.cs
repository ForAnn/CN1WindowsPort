// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui.html {
public class HTMLEventsListener: global::java.lang.Object,global::com.codename1.ui.events.ActionListener,global::com.codename1.ui.events.FocusListener {
public global::java.util.Hashtable _fcomps;

public global::java.util.Hashtable _flisteners;

public global::com.codename1.ui.html.HTMLComponent _fhtmlC;

public void @this(global::com.codename1.ui.html.HTMLComponent n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.HTMLEventsListener: void <init>(com.codename1.ui.html.HTMLComponent)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    ((global::java.lang.Object) _r1_o).@this();
    _r0_o = new global::java.util.Hashtable();
    ((global::java.util.Hashtable) _r0_o).@this();
    ((global::com.codename1.ui.html.HTMLEventsListener) _r1_o)._fcomps = (global::java.util.Hashtable) _r0_o;
    _r0_o = new global::java.util.Hashtable();
    ((global::java.util.Hashtable) _r0_o).@this();
    ((global::com.codename1.ui.html.HTMLEventsListener) _r1_o)._flisteners = (global::java.util.Hashtable) _r0_o;
    ((global::com.codename1.ui.html.HTMLEventsListener) _r1_o)._fhtmlC = (global::com.codename1.ui.html.HTMLComponent) _r2_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.html.HTMLEventsListener: void <init>(com.codename1.ui.html.HTMLComponent)]
}

public virtual void registerComponent(global::com.codename1.ui.Component n1, global::com.codename1.ui.html.HTMLElement n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.HTMLEventsListener: void registerComponent(com.codename1.ui.Component, com.codename1.ui.html.HTMLElement)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    global::System.Object _r7_o = null;
    global::System.Object _r8_o = null;
    _r6_o = this;
    _r7_o = n1;
    _r8_o = n2;
    _r5_o = ((global::com.codename1.ui.html.HTMLEventsListener) _r6_o)._fcomps;
    ((global::java.util.Hashtable) _r5_o).put((global::java.lang.Object) _r7_o, (global::java.lang.Object) _r8_o);
    ((global::com.codename1.ui.Component) _r7_o).addFocusListener((global::com.codename1.ui.events.FocusListener) _r6_o);
    _r5.i = ((_r7_o != null) && (_r7_o is global::com.codename1.ui.Button)) ? 1 : 0;
    if (_r5.i == 0) goto label18;
    _r7_o = _r7_o;
    ((global::com.codename1.ui.Button) _r7_o).addActionListener((global::com.codename1.ui.events.ActionListener) _r6_o);
    label17:;
    return;
    label18:;
    _r5.i = ((_r7_o != null) && (_r7_o is global::com.codename1.ui.List)) ? 1 : 0;
    if (_r5.i == 0) goto label43;
    _r0_o = _r7_o;
    _r0_o = _r0_o;
    _r2_o = _r0_o;
    ((global::com.codename1.ui.List) _r2_o).addActionListener((global::com.codename1.ui.events.ActionListener) _r6_o);
    _r3_o = new global::com.codename1.ui.html.HTMLEventsListener_21();
    ((global::com.codename1.ui.html.HTMLEventsListener_21) _r3_o).@this((global::com.codename1.ui.html.HTMLEventsListener) _r6_o, (global::com.codename1.ui.List) _r2_o, (global::com.codename1.ui.html.HTMLElement) _r8_o);
    ((global::com.codename1.ui.List) _r2_o).addSelectionListener((global::com.codename1.ui.events.SelectionListener) _r3_o);
    _r5_o = ((global::com.codename1.ui.html.HTMLEventsListener) _r6_o)._flisteners;
    ((global::java.util.Hashtable) _r5_o).put((global::java.lang.Object) _r7_o, (global::java.lang.Object) _r3_o);
    goto label17;
    label43:;
    _r5.i = ((_r7_o != null) && (_r7_o is global::com.codename1.ui.TextArea)) ? 1 : 0;
    if (_r5.i == 0) goto label17;
    _r0_o = _r7_o;
    _r0_o = _r0_o;
    _r5_o = _r0_o;
    ((global::com.codename1.ui.TextArea) _r5_o).addActionListener((global::com.codename1.ui.events.ActionListener) _r6_o);
    _r5.i = ((_r7_o != null) && (_r7_o is global::com.codename1.ui.TextField)) ? 1 : 0;
    if (_r5.i == 0) goto label17;
    _r0_o = _r7_o;
    _r0_o = _r0_o;
    _r4_o = _r0_o;
    _r1_o = new global::com.codename1.ui.html.HTMLEventsListener_22();
    ((global::com.codename1.ui.html.HTMLEventsListener_22) _r1_o).@this((global::com.codename1.ui.html.HTMLEventsListener) _r6_o, (global::com.codename1.ui.html.HTMLElement) _r8_o, (global::com.codename1.ui.TextField) _r4_o);
    ((global::com.codename1.ui.TextField) _r4_o).addDataChangeListener((global::com.codename1.ui.events.DataChangedListener) _r1_o);
    _r5_o = ((global::com.codename1.ui.html.HTMLEventsListener) _r6_o)._flisteners;
    ((global::java.util.Hashtable) _r5_o).put((global::java.lang.Object) _r7_o, (global::java.lang.Object) _r1_o);
    goto label17;
//XMLVM_END_WRAPPER[com.codename1.ui.html.HTMLEventsListener: void registerComponent(com.codename1.ui.Component, com.codename1.ui.html.HTMLElement)]
}

public virtual void deregisterAll(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.HTMLEventsListener: void deregisterAll()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    _r5_o = this;
    _r3_o = ((global::com.codename1.ui.html.HTMLEventsListener) _r5_o)._fcomps;
    _r2_o = ((global::java.util.Hashtable) _r3_o).keys();
    label6:;
    _r3.i = ((global::java.util.Enumeration) _r2_o).hasMoreElements() ? 1 : 0;
    if (_r3.i == 0) goto label82;
    _r1_o = ((global::java.util.Enumeration) _r2_o).nextElement();
    _r1_o = _r1_o;
    ((global::com.codename1.ui.Component) _r1_o).removeFocusListener((global::com.codename1.ui.events.FocusListener) _r5_o);
    _r3.i = ((_r1_o != null) && (_r1_o is global::com.codename1.ui.Button)) ? 1 : 0;
    if (_r3.i == 0) goto label31;
    _r1_o = _r1_o;
    ((global::com.codename1.ui.Button) _r1_o).removeActionListener((global::com.codename1.ui.events.ActionListener) _r5_o);
    goto label6;
    label31:;
    _r3.i = ((_r1_o != null) && (_r1_o is global::com.codename1.ui.List)) ? 1 : 0;
    if (_r3.i == 0) goto label51;
    _r0_o = _r1_o;
    _r0_o = _r0_o;
    _r3_o = _r0_o;
    _r4_o = ((global::com.codename1.ui.html.HTMLEventsListener) _r5_o)._flisteners;
    _r4_o = ((global::java.util.Hashtable) _r4_o).get((global::java.lang.Object) _r1_o);
    _r4_o = _r4_o;
    ((global::com.codename1.ui.List) _r3_o).removeSelectionListener((global::com.codename1.ui.events.SelectionListener) _r4_o);
    goto label6;
    label51:;
    _r3.i = ((_r1_o != null) && (_r1_o is global::com.codename1.ui.TextArea)) ? 1 : 0;
    if (_r3.i == 0) goto label6;
    _r0_o = _r1_o;
    _r0_o = _r0_o;
    _r3_o = _r0_o;
    ((global::com.codename1.ui.TextArea) _r3_o).removeActionListener((global::com.codename1.ui.events.ActionListener) _r5_o);
    _r3.i = ((_r1_o != null) && (_r1_o is global::com.codename1.ui.TextField)) ? 1 : 0;
    if (_r3.i == 0) goto label6;
    _r0_o = _r1_o;
    _r0_o = _r0_o;
    _r3_o = _r0_o;
    _r4_o = ((global::com.codename1.ui.html.HTMLEventsListener) _r5_o)._flisteners;
    _r4_o = ((global::java.util.Hashtable) _r4_o).get((global::java.lang.Object) _r1_o);
    _r4_o = _r4_o;
    ((global::com.codename1.ui.TextField) _r3_o).removeDataChangeListener((global::com.codename1.ui.events.DataChangedListener) _r4_o);
    goto label6;
    label82:;
    _r3_o = new global::java.util.Hashtable();
    ((global::java.util.Hashtable) _r3_o).@this();
    ((global::com.codename1.ui.html.HTMLEventsListener) _r5_o)._fcomps = (global::java.util.Hashtable) _r3_o;
    _r3_o = new global::java.util.Hashtable();
    ((global::java.util.Hashtable) _r3_o).@this();
    ((global::com.codename1.ui.html.HTMLEventsListener) _r5_o)._flisteners = (global::java.util.Hashtable) _r3_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.html.HTMLEventsListener: void deregisterAll()]
}

private void toggleChecked(global::com.codename1.ui.html.HTMLElement n1, bool n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.HTMLEventsListener: void toggleChecked(com.codename1.ui.html.HTMLElement, boolean)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    _r2_o = this;
    _r3_o = n1;
    _r4.i = n2 ? 1 : 0;
    _r1.i = 32;
    if (_r4.i == 0) goto label10;
    // Value=checked
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)99)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 107)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100))}));
    ((global::com.codename1.ui.html.HTMLElement) _r3_o).setAttributeById((int) _r1.i, (global::java.lang.String) _r0_o);
    label9:;
    return;
    label10:;
    ((global::com.codename1.ui.html.HTMLElement) _r3_o).removeAttributeById((int) _r1.i);
    goto label9;
//XMLVM_END_WRAPPER[com.codename1.ui.html.HTMLEventsListener: void toggleChecked(com.codename1.ui.html.HTMLElement, boolean)]
}

public virtual void actionPerformed(global::com.codename1.ui.events.ActionEvent n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.HTMLEventsListener: void actionPerformed(com.codename1.ui.events.ActionEvent)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    global::System.Object _r7_o = null;
    global::System.Object _r8_o = null;
    global::System.Object _r9_o = null;
    global::System.Object _r10_o = null;
    global::System.Object _r11_o = null;
    global::System.Object _r12_o = null;
    global::System.Object _r13_o = null;
    global::System.Object _r14_o = null;
    global::System.Object _r15_o = null;
    global::System.Object _r16_o = null;
    global::org.xmlvm._nElement _r17;
    global::System.Object _r17_o = null;
    global::org.xmlvm._nElement _r18;
    global::System.Object _r18_o = null;
    global::System.Object _r19_o = null;
    global::System.Object _r20_o = null;
    _r19_o = this;
    _r20_o = n1;
    _r13_o = ((global::com.codename1.ui.events.ActionEvent) _r20_o).getSource();
    _r0_o = _r19_o;
    _r0_o = ((global::com.codename1.ui.html.HTMLEventsListener) _r0_o)._fcomps;
    _r17_o = _r0_o;
    _r18_o = ((global::com.codename1.ui.events.ActionEvent) _r20_o).getSource();
    _r7_o = ((global::java.util.Hashtable) _r17_o).get((global::java.lang.Object) _r18_o);
    _r7_o = _r7_o;
    _r0_o = _r13_o;
    _r0.i = ((_r0_o != null) && (_r0_o is global::com.codename1.ui.CheckBox)) ? 1 : 0;
    _r17.i = _r0.i;
    if (_r17.i == 0) goto label80;
    _r13_o = _r13_o;
    _r17.i = ((global::com.codename1.ui.CheckBox) _r13_o).isSelected() ? 1 : 0;
    _r0_o = _r19_o;
    _r1_o = _r7_o;
    _r2.i = _r17.i;
    ((global::com.codename1.ui.html.HTMLEventsListener) _r0_o).toggleChecked((global::com.codename1.ui.html.HTMLElement) _r1_o, 0!=_r2.i);
    label41:;
    _r0_o = _r19_o;
    _r0_o = ((global::com.codename1.ui.html.HTMLEventsListener) _r0_o)._fhtmlC;
    _r17_o = _r0_o;
    _r17_o = ((global::com.codename1.ui.html.HTMLComponent) _r17_o).getHTMLCallback();
    if (_r17_o == null) goto label79;
    _r0_o = _r19_o;
    _r0_o = ((global::com.codename1.ui.html.HTMLEventsListener) _r0_o)._fhtmlC;
    _r17_o = _r0_o;
    _r17_o = ((global::com.codename1.ui.html.HTMLComponent) _r17_o).getHTMLCallback();
    _r0_o = _r19_o;
    _r0_o = ((global::com.codename1.ui.html.HTMLEventsListener) _r0_o)._fhtmlC;
    _r18_o = _r0_o;
    _r0_o = _r17_o;
    _r1_o = _r20_o;
    _r2_o = _r18_o;
    _r3_o = _r7_o;
    ((global::com.codename1.ui.html.HTMLCallback) _r0_o).actionPerformed((global::com.codename1.ui.events.ActionEvent) _r1_o, (global::com.codename1.ui.html.HTMLComponent) _r2_o, (global::com.codename1.ui.html.HTMLElement) _r3_o);
    label79:;
    return;
    label80:;
    _r0_o = _r13_o;
    _r0.i = ((_r0_o != null) && (_r0_o is global::com.codename1.ui.RadioButton)) ? 1 : 0;
    _r17.i = _r0.i;
    if (_r17.i == 0) goto label206;
    _r17.i = 32;
    _r0_o = _r7_o;
    _r1.i = _r17.i;
    _r5_o = ((global::com.codename1.ui.html.HTMLElement) _r0_o).getAttributeById((int) _r1.i);
    if (_r5_o == null) goto label109;
    // Value=checked
    _r17_o = new global::java.lang.String();
    ((global::java.lang.String)_r17_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)99)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 107)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100))}));
    _r0_o = _r5_o;
    _r1_o = _r17_o;
    _r17.i = ((global::java.lang.String) _r0_o).equals((global::java.lang.Object) _r1_o) ? 1 : 0;
    if (_r17.i != 0) goto label190;
    label109:;
    _r17.i = 37;
    _r0_o = _r7_o;
    _r1.i = _r17.i;
    _r9_o = ((global::com.codename1.ui.html.HTMLElement) _r0_o).getAttributeById((int) _r1.i);
    if (_r9_o == null) goto label190;
    _r0_o = _r19_o;
    _r0_o = ((global::com.codename1.ui.html.HTMLEventsListener) _r0_o)._fcomps;
    _r17_o = _r0_o;
    _r6_o = ((global::java.util.Hashtable) _r17_o).keys();
    label130:;
    _r17.i = ((global::java.util.Enumeration) _r6_o).hasMoreElements() ? 1 : 0;
    if (_r17.i == 0) goto label190;
    _r4_o = ((global::java.util.Enumeration) _r6_o).nextElement();
    _r4_o = _r4_o;
    _r0_o = _r4_o;
    _r0.i = ((_r0_o != null) && (_r0_o is global::com.codename1.ui.RadioButton)) ? 1 : 0;
    _r17.i = _r0.i;
    if (_r17.i == 0) goto label130;
    _r0_o = _r19_o;
    _r0_o = ((global::com.codename1.ui.html.HTMLEventsListener) _r0_o)._fcomps;
    _r17_o = _r0_o;
    _r0_o = _r17_o;
    _r1_o = _r4_o;
    _r11_o = ((global::java.util.Hashtable) _r0_o).get((global::java.lang.Object) _r1_o);
    _r11_o = _r11_o;
    _r17.i = 37;
    _r0_o = _r11_o;
    _r1.i = _r17.i;
    _r12_o = ((global::com.codename1.ui.html.HTMLElement) _r0_o).getAttributeById((int) _r1.i);
    if (_r12_o == null) goto label130;
    _r17.i = ((global::java.lang.String) _r12_o).equals((global::java.lang.Object) _r9_o) ? 1 : 0;
    if (_r17.i == 0) goto label130;
    _r17.i = 32;
    _r0_o = _r11_o;
    _r1.i = _r17.i;
    ((global::com.codename1.ui.html.HTMLElement) _r0_o).removeAttributeById((int) _r1.i);
    goto label130;
    label190:;
    _r13_o = _r13_o;
    _r17.i = ((global::com.codename1.ui.RadioButton) _r13_o).isSelected() ? 1 : 0;
    _r0_o = _r19_o;
    _r1_o = _r7_o;
    _r2.i = _r17.i;
    ((global::com.codename1.ui.html.HTMLEventsListener) _r0_o).toggleChecked((global::com.codename1.ui.html.HTMLElement) _r1_o, 0!=_r2.i);
    goto label41;
    label206:;
    _r0_o = _r13_o;
    _r0.i = ((_r0_o != null) && (_r0_o is global::com.codename1.ui.TextArea)) ? 1 : 0;
    _r17.i = _r0.i;
    if (_r17.i == 0) goto label272;
    _r13_o = _r13_o;
    _r14_o = ((global::com.codename1.ui.TextArea) _r13_o).getText();
    _r17.i = ((global::com.codename1.ui.html.HTMLElement) _r7_o).getNumChildren();
    if (_r17.i != 0) goto label241;
    _r15_o = new global::com.codename1.ui.html.HTMLElement();
    _r17.i = 1;
    _r0_o = _r15_o;
    _r1_o = _r14_o;
    _r2.i = _r17.i;
    ((global::com.codename1.ui.html.HTMLElement) _r0_o).@this((global::java.lang.String) _r1_o, 0!=_r2.i);
    ((global::com.codename1.ui.html.HTMLElement) _r7_o).addChild((global::com.codename1.xml.Element) _r15_o);
    goto label41;
    label241:;
    _r17.i = 0;
    _r0_o = _r7_o;
    _r1.i = _r17.i;
    _r15_o = ((global::com.codename1.ui.html.HTMLElement) _r0_o).getChildAt((int) _r1.i);
    _r15_o = _r15_o;
    _r17.i = ((global::com.codename1.ui.html.HTMLElement) _r15_o).isTextElement() ? 1 : 0;
    if (_r17.i == 0) goto label263;
    ((global::com.codename1.ui.html.HTMLElement) _r15_o).setText((global::java.lang.String) _r14_o);
    goto label41;
    label263:;
    _r17_o = global::java.lang.System._fout;
    // Value=Malformed HTML - Found a non-text element under TEXTAREA tag - ignoring
    _r18_o = new global::java.lang.String();
    ((global::java.lang.String)_r18_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)77)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 72)), unchecked((char) unchecked((uint) 84)), unchecked((char) unchecked((uint) 77)), unchecked((char) unchecked((uint) 76)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 70)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 84)), unchecked((char) unchecked((uint) 69)), unchecked((char) unchecked((uint) 88)), unchecked((char) unchecked((uint) 84)), unchecked((char) unchecked((uint) 65)), unchecked((char) unchecked((uint) 82)), unchecked((char) unchecked((uint) 69)), unchecked((char) unchecked((uint) 65)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 103))}));
    ((global::java.io.PrintStream) _r17_o).println((global::java.lang.String) _r18_o);
    goto label41;
    label272:;
    _r0_o = _r13_o;
    _r0.i = ((_r0_o != null) && (_r0_o is global::com.codename1.ui.List)) ? 1 : 0;
    _r17.i = _r0.i;
    if (_r17.i == 0) goto label41;
    _r13_o = _r13_o;
    _r17_o = ((global::com.codename1.ui.List) _r13_o).getSelectedItem();
    _r8_o = ((global::java.lang.Object) _r17_o).toString();
    _r17.i = 39;
    _r0_o = _r7_o;
    _r1.i = _r17.i;
    _r16_o = ((global::com.codename1.ui.html.HTMLElement) _r0_o).getDescendantsByTagId((int) _r1.i);
    _r6_o = ((global::java.util.Vector) _r16_o).elements();
    label302:;
    _r17.i = ((global::java.util.Enumeration) _r6_o).hasMoreElements() ? 1 : 0;
    if (_r17.i == 0) goto label41;
    _r10_o = ((global::java.util.Enumeration) _r6_o).nextElement();
    _r10_o = _r10_o;
    _r17.i = ((global::com.codename1.ui.html.HTMLElement) _r10_o).getNumChildren();
    _r18.i = 1;
    _r0.i = _r17.i;
    _r1.i = _r18.i;
    if (_r0.i != _r1.i) goto label386;
    _r17.i = 0;
    _r0_o = _r10_o;
    _r1.i = _r17.i;
    _r15_o = ((global::com.codename1.ui.html.HTMLElement) _r0_o).getChildAt((int) _r1.i);
    _r15_o = _r15_o;
    _r17.i = ((global::com.codename1.ui.html.HTMLElement) _r15_o).isTextElement() ? 1 : 0;
    if (_r17.i == 0) goto label378;
    _r17_o = ((global::com.codename1.ui.html.HTMLElement) _r15_o).getText();
    _r0_o = _r17_o;
    _r1_o = _r8_o;
    _r17.i = ((global::java.lang.String) _r0_o).equalsIgnoreCase((global::java.lang.String) _r1_o) ? 1 : 0;
    if (_r17.i == 0) goto label369;
    _r17.i = 42;
    // Value=selected
    _r18_o = new global::java.lang.String();
    ((global::java.lang.String)_r18_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)115)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100))}));
    _r0_o = _r10_o;
    _r1.i = _r17.i;
    _r2_o = _r18_o;
    ((global::com.codename1.ui.html.HTMLElement) _r0_o).setAttributeById((int) _r1.i, (global::java.lang.String) _r2_o);
    goto label302;
    label369:;
    _r17.i = 42;
    _r0_o = _r10_o;
    _r1.i = _r17.i;
    ((global::com.codename1.ui.html.HTMLElement) _r0_o).removeAttributeById((int) _r1.i);
    goto label302;
    label378:;
    _r17_o = global::java.lang.System._fout;
    // Value=Malformed HTML - Found a non-text element under OPTION tag - ignoring
    _r18_o = new global::java.lang.String();
    ((global::java.lang.String)_r18_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)77)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 72)), unchecked((char) unchecked((uint) 84)), unchecked((char) unchecked((uint) 77)), unchecked((char) unchecked((uint) 76)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 70)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 79)), unchecked((char) unchecked((uint) 80)), unchecked((char) unchecked((uint) 84)), unchecked((char) unchecked((uint) 73)), unchecked((char) unchecked((uint) 79)), unchecked((char) unchecked((uint) 78)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 103))}));
    ((global::java.io.PrintStream) _r17_o).println((global::java.lang.String) _r18_o);
    goto label302;
    label386:;
    _r17_o = global::java.lang.System._fout;
    // Value=Malformed HTML - Found illegal tags as children of the OPTION tag - ignoring
    _r18_o = new global::java.lang.String();
    ((global::java.lang.String)_r18_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)77)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 72)), unchecked((char) unchecked((uint) 84)), unchecked((char) unchecked((uint) 77)), unchecked((char) unchecked((uint) 76)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 70)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 79)), unchecked((char) unchecked((uint) 80)), unchecked((char) unchecked((uint) 84)), unchecked((char) unchecked((uint) 73)), unchecked((char) unchecked((uint) 79)), unchecked((char) unchecked((uint) 78)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 103))}));
    ((global::java.io.PrintStream) _r17_o).println((global::java.lang.String) _r18_o);
    goto label302;
//XMLVM_END_WRAPPER[com.codename1.ui.html.HTMLEventsListener: void actionPerformed(com.codename1.ui.events.ActionEvent)]
}

public virtual void focusGained(global::com.codename1.ui.Component n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.HTMLEventsListener: void focusGained(com.codename1.ui.Component)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    _r3_o = this;
    _r4_o = n1;
    _r0_o = ((global::com.codename1.ui.html.HTMLEventsListener) _r3_o)._fhtmlC;
    _r0_o = ((global::com.codename1.ui.html.HTMLComponent) _r0_o).getHTMLCallback();
    if (_r0_o == null) goto label27;
    _r0_o = ((global::com.codename1.ui.html.HTMLEventsListener) _r3_o)._fhtmlC;
    _r0_o = ((global::com.codename1.ui.html.HTMLComponent) _r0_o).getHTMLCallback();
    _r1_o = ((global::com.codename1.ui.html.HTMLEventsListener) _r3_o)._fhtmlC;
    _r2_o = ((global::com.codename1.ui.html.HTMLEventsListener) _r3_o)._fcomps;
    _r3_o = ((global::java.util.Hashtable) _r2_o).get((global::java.lang.Object) _r4_o);
    _r3_o = _r3_o;
    ((global::com.codename1.ui.html.HTMLCallback) _r0_o).focusGained((global::com.codename1.ui.Component) _r4_o, (global::com.codename1.ui.html.HTMLComponent) _r1_o, (global::com.codename1.ui.html.HTMLElement) _r3_o);
    label27:;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.html.HTMLEventsListener: void focusGained(com.codename1.ui.Component)]
}

public virtual void focusLost(global::com.codename1.ui.Component n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.HTMLEventsListener: void focusLost(com.codename1.ui.Component)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    _r3_o = this;
    _r4_o = n1;
    _r0_o = ((global::com.codename1.ui.html.HTMLEventsListener) _r3_o)._fhtmlC;
    _r0_o = ((global::com.codename1.ui.html.HTMLComponent) _r0_o).getHTMLCallback();
    if (_r0_o == null) goto label27;
    _r0_o = ((global::com.codename1.ui.html.HTMLEventsListener) _r3_o)._fhtmlC;
    _r0_o = ((global::com.codename1.ui.html.HTMLComponent) _r0_o).getHTMLCallback();
    _r1_o = ((global::com.codename1.ui.html.HTMLEventsListener) _r3_o)._fhtmlC;
    _r2_o = ((global::com.codename1.ui.html.HTMLEventsListener) _r3_o)._fcomps;
    _r3_o = ((global::java.util.Hashtable) _r2_o).get((global::java.lang.Object) _r4_o);
    _r3_o = _r3_o;
    ((global::com.codename1.ui.html.HTMLCallback) _r0_o).focusLost((global::com.codename1.ui.Component) _r4_o, (global::com.codename1.ui.html.HTMLComponent) _r1_o, (global::com.codename1.ui.html.HTMLElement) _r3_o);
    label27:;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.html.HTMLEventsListener: void focusLost(com.codename1.ui.Component)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.HTMLEventsListener]
//XMLVM_END_WRAPPER[com.codename1.ui.html.HTMLEventsListener]

} // end of class: HTMLEventsListener

} // end of namespace: com.codename1.ui.html
