// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace gnu.xml.dom {
public class DomEvent: global::java.lang.Object,global::org.w3c.dom.events.Event {
public global::java.lang.String _ftype;

public global::org.w3c.dom.events.EventTarget _ftarget;

public global::org.w3c.dom.events.EventTarget _fcurrentNode;

public short _feventPhase;

public bool _fbubbles;

public bool _fcancelable;

public long _ftimeStamp;

public bool _fstop;

public bool _fdoDefault;

public static short _fCAPTURING_1PHASE = org.w3c.dom.events._iEvent._fCAPTURING_1PHASE;

public static short _fAT_1TARGET = org.w3c.dom.events._iEvent._fAT_1TARGET;

public static short _fBUBBLING_1PHASE = org.w3c.dom.events._iEvent._fBUBBLING_1PHASE;

public virtual global::System.Object getType(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomEvent: java.lang.String getType()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::gnu.xml.dom.DomEvent) _r1_o)._ftype;
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[gnu.xml.dom.DomEvent: java.lang.String getType()]
}

public virtual global::System.Object getTarget(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomEvent: org.w3c.dom.events.EventTarget getTarget()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::gnu.xml.dom.DomEvent) _r1_o)._ftarget;
    return (global::org.w3c.dom.events.EventTarget) _r0_o;
//XMLVM_END_WRAPPER[gnu.xml.dom.DomEvent: org.w3c.dom.events.EventTarget getTarget()]
}

public virtual global::System.Object getCurrentTarget(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomEvent: org.w3c.dom.events.EventTarget getCurrentTarget()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::gnu.xml.dom.DomEvent) _r1_o)._fcurrentNode;
    return (global::org.w3c.dom.events.EventTarget) _r0_o;
//XMLVM_END_WRAPPER[gnu.xml.dom.DomEvent: org.w3c.dom.events.EventTarget getCurrentTarget()]
}

public virtual short getEventPhase(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomEvent: short getEventPhase()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::gnu.xml.dom.DomEvent) _r1_o)._feventPhase;
    return (short) _r0.i;
//XMLVM_END_WRAPPER[gnu.xml.dom.DomEvent: short getEventPhase()]
}

public virtual bool getBubbles(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomEvent: boolean getBubbles()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::gnu.xml.dom.DomEvent) _r1_o)._fbubbles ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[gnu.xml.dom.DomEvent: boolean getBubbles()]
}

public virtual bool getCancelable(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomEvent: boolean getCancelable()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::gnu.xml.dom.DomEvent) _r1_o)._fcancelable ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[gnu.xml.dom.DomEvent: boolean getCancelable()]
}

public virtual long getTimeStamp(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomEvent: long getTimeStamp()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0.l = ((global::gnu.xml.dom.DomEvent) _r2_o)._ftimeStamp;
    return _r0.l;
//XMLVM_END_WRAPPER[gnu.xml.dom.DomEvent: long getTimeStamp()]
}

public virtual void stopPropagation(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomEvent: void stopPropagation()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = 1;
    ((global::gnu.xml.dom.DomEvent) _r1_o)._fstop = 0!=_r0.i;
    return;
//XMLVM_END_WRAPPER[gnu.xml.dom.DomEvent: void stopPropagation()]
}

public virtual void preventDefault(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomEvent: void preventDefault()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = 0;
    ((global::gnu.xml.dom.DomEvent) _r1_o)._fdoDefault = 0!=_r0.i;
    return;
//XMLVM_END_WRAPPER[gnu.xml.dom.DomEvent: void preventDefault()]
}

public virtual void initEvent(global::java.lang.String n1, bool n2, bool n3){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomEvent: void initEvent(java.lang.String, boolean, boolean)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    _r2_o = this;
    _r3_o = n1;
    _r4.i = n2 ? 1 : 0;
    _r5.i = n3 ? 1 : 0;
    _r0.i = 0;
    ((global::gnu.xml.dom.DomEvent) _r2_o)._feventPhase = (short) _r0.i;
    ((global::gnu.xml.dom.DomEvent) _r2_o)._ftype = (global::java.lang.String) _r3_o;
    ((global::gnu.xml.dom.DomEvent) _r2_o)._fbubbles = 0!=_r4.i;
    ((global::gnu.xml.dom.DomEvent) _r2_o)._fcancelable = 0!=_r5.i;
    _r0.l = global::java.lang.System.currentTimeMillis();
    ((global::gnu.xml.dom.DomEvent) _r2_o)._ftimeStamp = _r0.l;
    return;
//XMLVM_END_WRAPPER[gnu.xml.dom.DomEvent: void initEvent(java.lang.String, boolean, boolean)]
}

public void @this(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomEvent: void <init>(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::java.lang.Object) _r0_o).@this();
    ((global::gnu.xml.dom.DomEvent) _r0_o)._ftype = (global::java.lang.String) _r1_o;
    return;
//XMLVM_END_WRAPPER[gnu.xml.dom.DomEvent: void <init>(java.lang.String)]
}

public override global::System.Object toString(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomEvent: java.lang.String toString()]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    _r3_o = this;
    _r0_o = new global::gnu.java.lang.CPStringBuilder();
    // Value=[Event 
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)91)), unchecked((char) unchecked((uint) 69)), unchecked((char) unchecked((uint) 118)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 32))}));
    ((global::gnu.java.lang.CPStringBuilder) _r0_o).@this((global::java.lang.String) _r1_o);
    _r1_o = ((global::gnu.xml.dom.DomEvent) _r3_o)._ftype;
    ((global::gnu.java.lang.CPStringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r1.i = ((global::gnu.xml.dom.DomEvent) _r3_o)._feventPhase;
    switch (_r1.i) {
    case 1: goto label55;
    case 2: goto label61;
    case 3: goto label67;
    }
    // Value=, (inactive)
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)44)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 40)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 118)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 41))}));
    ((global::gnu.java.lang.CPStringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    label22:;
    _r1.i = ((global::gnu.xml.dom.DomEvent) _r3_o)._fbubbles ? 1 : 0;
    if (_r1.i == 0) goto label36;
    _r1.i = ((global::gnu.xml.dom.DomEvent) _r3_o)._feventPhase;
    _r2.i = 3;
    if (_r1.i == _r2.i) goto label36;
    // Value=, bubbles
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)44)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 115))}));
    ((global::gnu.java.lang.CPStringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    label36:;
    _r1.i = ((global::gnu.xml.dom.DomEvent) _r3_o)._fcancelable ? 1 : 0;
    if (_r1.i == 0) goto label45;
    // Value=, can cancel
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)44)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 108))}));
    ((global::gnu.java.lang.CPStringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    label45:;
    // Value=]
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)93))}));
    ((global::gnu.java.lang.CPStringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r0_o = ((global::gnu.java.lang.CPStringBuilder) _r0_o).toString();
    return (global::java.lang.String) _r0_o;
    label55:;
    // Value=, CAPTURING
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)44)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 67)), unchecked((char) unchecked((uint) 65)), unchecked((char) unchecked((uint) 80)), unchecked((char) unchecked((uint) 84)), unchecked((char) unchecked((uint) 85)), unchecked((char) unchecked((uint) 82)), unchecked((char) unchecked((uint) 73)), unchecked((char) unchecked((uint) 78)), unchecked((char) unchecked((uint) 71))}));
    ((global::gnu.java.lang.CPStringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    goto label22;
    label61:;
    // Value=, AT TARGET
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)44)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 65)), unchecked((char) unchecked((uint) 84)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 84)), unchecked((char) unchecked((uint) 65)), unchecked((char) unchecked((uint) 82)), unchecked((char) unchecked((uint) 71)), unchecked((char) unchecked((uint) 69)), unchecked((char) unchecked((uint) 84))}));
    ((global::gnu.java.lang.CPStringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    goto label22;
    label67:;
    // Value=, BUBBLING
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)44)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 66)), unchecked((char) unchecked((uint) 85)), unchecked((char) unchecked((uint) 66)), unchecked((char) unchecked((uint) 66)), unchecked((char) unchecked((uint) 76)), unchecked((char) unchecked((uint) 73)), unchecked((char) unchecked((uint) 78)), unchecked((char) unchecked((uint) 71))}));
    ((global::gnu.java.lang.CPStringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    goto label22;
//XMLVM_END_WRAPPER[gnu.xml.dom.DomEvent: java.lang.String toString()]
}

//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomEvent]
//XMLVM_END_WRAPPER[gnu.xml.dom.DomEvent]

} // end of class: DomEvent

} // end of namespace: gnu.xml.dom
