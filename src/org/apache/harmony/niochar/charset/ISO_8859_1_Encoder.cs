// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace org.apache.harmony.niochar.charset {
public class ISO_18859_11_2Encoder: global::java.nio.charset.CharsetEncoder {
public global::org.apache.harmony.niochar.charset.ISO_18859_11 _fthis_20;

private void @this(global::org.apache.harmony.niochar.charset.ISO_18859_11 n1, global::java.nio.charset.Charset n2){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.niochar.charset.ISO_8859_1$Encoder: void <init>(org.apache.harmony.niochar.charset.ISO_8859_1, java.nio.charset.Charset)]
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
    _r0.f = (float)1.0D;
    ((global::org.apache.harmony.niochar.charset.ISO_18859_11_2Encoder) _r1_o)._fthis_20 = (global::org.apache.harmony.niochar.charset.ISO_18859_11) _r2_o;
    ((global::java.nio.charset.CharsetEncoder) _r1_o).@this((global::java.nio.charset.Charset) _r3_o, (float) _r0.f, (float) _r0.f);
    return;
//XMLVM_END_WRAPPER[org.apache.harmony.niochar.charset.ISO_8859_1$Encoder: void <init>(org.apache.harmony.niochar.charset.ISO_8859_1, java.nio.charset.Charset)]
}

private void nEncode(long n1, int n2, global::org.xmlvm._nArrayAdapter<char> n3, int n4, global::org.xmlvm._nArrayAdapter<int> n5){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.niochar.charset.ISO_8859_1$Encoder: void nEncode(long, int, char[], int, int[])]
      throw new global::org.xmlvm._nNotYetImplementedException("native/wrapper method not yet implemented");
//XMLVM_END_WRAPPER[org.apache.harmony.niochar.charset.ISO_8859_1$Encoder: void nEncode(long, int, char[], int, int[])]
}

public override global::System.Object encodeLoop(global::java.nio.CharBuffer n1, global::java.nio.ByteBuffer n2){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.niochar.charset.ISO_8859_1$Encoder: java.nio.charset.CoderResult encodeLoop(java.nio.CharBuffer, java.nio.ByteBuffer)]
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
    global::org.xmlvm._nElement _r11;
    global::System.Object _r11_o = null;
    global::org.xmlvm._nElement _r12;
    global::System.Object _r12_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r10_o = this;
    _r11_o = n1;
    _r12_o = n2;
    _r0.i = ((global::java.nio.CharBuffer) _r11_o).remaining();
    if (_r0.i != 0) goto label9;
    _r0_o = global::java.nio.charset.CoderResult._fUNDERFLOW;
    label8:;
    return (global::java.nio.charset.CoderResult) _r0_o;
    label9:;
    _r1.i = ((global::java.nio.ByteBuffer) _r12_o).remaining();
    _r2.i = ((global::java.nio.CharBuffer) _r11_o).hasArray() ? 1 : 0;
    _r3.i = ((global::java.nio.ByteBuffer) _r12_o).hasArray() ? 1 : 0;
    if (_r2.i == 0) goto label404;
    if (_r3.i == 0) goto label147;
    _r2_o = ((global::java.nio.ByteBuffer) _r12_o).array();
    _r3_o = ((global::java.nio.CharBuffer) _r11_o).array();
    _r4.i = ((global::java.nio.ByteBuffer) _r12_o).position();
    if (_r1.i > _r0.i) goto label40;
    _r0.i = _r1.i;
    label40:;
    _r5.i = ((global::java.nio.CharBuffer) _r11_o).position();
    _r6.i = 0;
    _r7.i = _r4.i;
    _r4.i = _r6.i;
    _r6.i = _r5.i;
    label48:;
    _r8.i = _r5.i + _r0.i;
    if (_r6.i < _r8.i) goto label74;
    _r2.i = _r4.i;
    label53:;
    ((global::java.nio.ByteBuffer) _r12_o).position((int) _r7.i);
    ((global::java.nio.CharBuffer) _r11_o).position((int) _r6.i);
    _r4.i = _r5.i + _r0.i;
    if (_r6.i != _r4.i) goto label92;
    if (_r0.i != _r1.i) goto label89;
    _r0.i = ((global::java.nio.CharBuffer) _r11_o).hasRemaining() ? 1 : 0;
    if (_r0.i == 0) goto label89;
    _r0_o = global::java.nio.charset.CoderResult._fOVERFLOW;
    goto label8;
    label74:;
    _r4.i = ((global::org.xmlvm._nArrayAdapter<char>) _r3_o)[_r6.i];
    _r8.i = 255;
    if (_r4.i > _r8.i) goto label406;
    _r8.i = _r7.i + 1;
    _r9.i = (_r4.i << 24) >> 24;
    ((global::org.xmlvm._nArrayAdapter<sbyte>) _r2_o)[_r7.i] = (sbyte)_r9.i;
    _r6.i = _r6.i + 1;
    _r7.i = _r8.i;
    goto label48;
    label89:;
    _r0_o = global::java.nio.charset.CoderResult._fUNDERFLOW;
    goto label8;
    label92:;
    _r0.i = 55296;
    if (_r2.i < _r0.i) goto label140;
    _r0.i = 57343;
    if (_r2.i > _r0.i) goto label140;
    _r0.i = _r6.i + 1;
    _r1.i = ((global::java.nio.CharBuffer) _r11_o).limit();
    if (_r0.i >= _r1.i) goto label130;
    _r0.i = _r6.i + 1;
    _r0.i = ((global::org.xmlvm._nArrayAdapter<char>) _r3_o)[_r0.i];
    _r1.i = 55296;
    if (_r0.i < _r1.i) goto label133;
    _r1.i = 57343;
    if (_r0.i > _r1.i) goto label133;
    _r0.i = 2;
    _r0_o = global::java.nio.charset.CoderResult.unmappableForLength((int) _r0.i);
    goto label8;
    label130:;
    _r0_o = global::java.nio.charset.CoderResult._fUNDERFLOW;
    goto label8;
    label133:;
    _r0.i = 1;
    _r0_o = global::java.nio.charset.CoderResult.malformedForLength((int) _r0.i);
    goto label8;
    label140:;
    _r0.i = 1;
    _r0_o = global::java.nio.charset.CoderResult.unmappableForLength((int) _r0.i);
    goto label8;
    label147:;
    _r2.i = global::org.apache.harmony.niochar.CharsetProviderImpl.hasLoadedNatives() ? 1 : 0;
    if (_r2.i == 0) goto label404;
    _r2.i = ((global::java.nio.ByteBuffer) _r12_o).isDirect() ? 1 : 0;
    if (_r2.i == 0) goto label404;
    _r2.i = 0;
    _r7.i = ((global::java.nio.CharBuffer) _r11_o).position();
    _r3.i = ((global::java.nio.ByteBuffer) _r12_o).position();
    if (_r1.i >= _r0.i) goto label401;
    _r0.i = 1;
    _r8.i = _r0.i;
    _r0.i = _r1.i;
    label173:;
    _r1.i = 2;
    _r6_o = new global::org.xmlvm._nArrayAdapter<int>(new int[_r1.i]);
    _r1.i = 0;
    ((global::org.xmlvm._nArrayAdapter<int>) _r6_o)[_r1.i] = _r0.i;
// Red class access removed: org.apache.harmony.nio.AddressUtil getDirectBufferAddress
throw new global::org.xmlvm._nNotYetImplementedException("Red class access removed: org.apache.harmony.nio.AddressUtil getDirectBufferAddress");
    _r4_o = ((global::java.nio.CharBuffer) _r11_o).array();
    _r0.i = ((global::java.nio.CharBuffer) _r11_o).arrayOffset();
    _r5.i = _r0.i + _r7.i;
    _r0_o = _r10_o;
    ((global::org.apache.harmony.niochar.charset.ISO_18859_11_2Encoder) _r0_o).nEncode((long) _r1.l, (int) _r3.i, (global::org.xmlvm._nArrayAdapter<char>) _r4_o, (int) _r5.i, (global::org.xmlvm._nArrayAdapter<int>) _r6_o);
    _r0.i = 0;
    _r0.i = ((global::org.xmlvm._nArrayAdapter<int>) _r6_o)[_r0.i];
    if (_r0.i > 0) goto label247;
    _r0.i = 0;
    _r0.i = ((global::org.xmlvm._nArrayAdapter<int>) _r6_o)[_r0.i];
    _r0.i = _r3.i - _r0.i;
    ((global::java.nio.ByteBuffer) _r12_o).position((int) _r0.i);
    _r0.i = 0;
    _r0.i = ((global::org.xmlvm._nArrayAdapter<int>) _r6_o)[_r0.i];
    _r0.i = _r7.i - _r0.i;
    ((global::java.nio.CharBuffer) _r11_o).position((int) _r0.i);
    _r0.i = 1;
    _r0.i = ((global::org.xmlvm._nArrayAdapter<int>) _r6_o)[_r0.i];
    if (_r0.i == 0) goto label267;
    _r0.i = 1;
    _r0.i = ((global::org.xmlvm._nArrayAdapter<int>) _r6_o)[_r0.i];
    if (_r0.i >= 0) goto label238;
    _r0.i = 1;
    _r0.i = ((global::org.xmlvm._nArrayAdapter<int>) _r6_o)[_r0.i];
    _r0.i = -_r0.i;
    _r0_o = global::java.nio.charset.CoderResult.malformedForLength((int) _r0.i);
    goto label8;
    label238:;
    _r0.i = 1;
    _r0.i = ((global::org.xmlvm._nArrayAdapter<int>) _r6_o)[_r0.i];
    _r0_o = global::java.nio.charset.CoderResult.unmappableForLength((int) _r0.i);
    goto label8;
    label247:;
    _r0.i = 0;
    _r0.i = ((global::org.xmlvm._nArrayAdapter<int>) _r6_o)[_r0.i];
    _r0.i = _r0.i + _r3.i;
    ((global::java.nio.ByteBuffer) _r12_o).position((int) _r0.i);
    _r0.i = 0;
    _r0.i = ((global::org.xmlvm._nArrayAdapter<int>) _r6_o)[_r0.i];
    _r0.i = _r0.i + _r7.i;
    ((global::java.nio.CharBuffer) _r11_o).position((int) _r0.i);
    if (_r8.i == 0) goto label267;
    _r0_o = global::java.nio.charset.CoderResult._fOVERFLOW;
    goto label8;
    label267:;
    _r0_o = global::java.nio.charset.CoderResult._fUNDERFLOW;
    goto label8;
    label271:;
    if (_r0.i != 0) goto label277;
    _r0_o = global::java.nio.charset.CoderResult._fOVERFLOW;
    goto label8;
    label277:;
    _r1.i = ((global::java.nio.CharBuffer) _r11_o).get();
    _r2.i = 255;
    if (_r1.i <= _r2.i) goto label385;
    _r0.i = 55296;
    if (_r1.i < _r0.i) goto label369;
    _r0.i = 57343;
    if (_r1.i > _r0.i) goto label369;
    _r0.i = ((global::java.nio.CharBuffer) _r11_o).hasRemaining() ? 1 : 0;
    if (_r0.i == 0) goto label356;
    _r0.i = ((global::java.nio.CharBuffer) _r11_o).get();
    _r1.i = 55296;
    if (_r0.i < _r1.i) goto label331;
    _r1.i = 57343;
    if (_r0.i > _r1.i) goto label331;
    _r0.i = ((global::java.nio.CharBuffer) _r11_o).position();
    _r1.i = 2;
    _r0.i = _r0.i - _r1.i;
    ((global::java.nio.CharBuffer) _r11_o).position((int) _r0.i);
    _r0.i = 2;
    _r0_o = global::java.nio.charset.CoderResult.unmappableForLength((int) _r0.i);
    goto label8;
    label331:;
    _r0.i = ((global::java.nio.CharBuffer) _r11_o).position();
    _r1.i = 1;
    _r0.i = _r0.i - _r1.i;
    ((global::java.nio.CharBuffer) _r11_o).position((int) _r0.i);
    _r0.i = ((global::java.nio.CharBuffer) _r11_o).position();
    _r1.i = 1;
    _r0.i = _r0.i - _r1.i;
    ((global::java.nio.CharBuffer) _r11_o).position((int) _r0.i);
    _r0.i = 1;
    _r0_o = global::java.nio.charset.CoderResult.malformedForLength((int) _r0.i);
    goto label8;
    label356:;
    _r0.i = ((global::java.nio.CharBuffer) _r11_o).position();
    _r1.i = 1;
    _r0.i = _r0.i - _r1.i;
    ((global::java.nio.CharBuffer) _r11_o).position((int) _r0.i);
    _r0_o = global::java.nio.charset.CoderResult._fUNDERFLOW;
    goto label8;
    label369:;
    _r0.i = ((global::java.nio.CharBuffer) _r11_o).position();
    _r1.i = 1;
    _r0.i = _r0.i - _r1.i;
    ((global::java.nio.CharBuffer) _r11_o).position((int) _r0.i);
    _r0.i = 1;
    _r0_o = global::java.nio.charset.CoderResult.unmappableForLength((int) _r0.i);
    goto label8;
    label385:;
    _r1.i = (_r1.i << 24) >> 24;
    ((global::java.nio.ByteBuffer) _r12_o).put((sbyte) _r1.i);
    _r0.i = _r0.i + -1;
    label391:;
    _r1.i = ((global::java.nio.CharBuffer) _r11_o).hasRemaining() ? 1 : 0;
    if (_r1.i != 0) goto label271;
    _r0_o = global::java.nio.charset.CoderResult._fUNDERFLOW;
    goto label8;
    label401:;
    _r8.i = _r2.i;
    goto label173;
    label404:;
    _r0.i = _r1.i;
    goto label391;
    label406:;
    _r2.i = _r4.i;
    goto label53;
//XMLVM_END_WRAPPER[org.apache.harmony.niochar.charset.ISO_8859_1$Encoder: java.nio.charset.CoderResult encodeLoop(java.nio.CharBuffer, java.nio.ByteBuffer)]
}

public void @this(global::org.apache.harmony.niochar.charset.ISO_18859_11 n1, global::java.nio.charset.Charset n2, global::org.apache.harmony.niochar.charset.ISO_18859_11_2Encoder n3){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.niochar.charset.ISO_8859_1$Encoder: void <init>(org.apache.harmony.niochar.charset.ISO_8859_1, java.nio.charset.Charset, org.apache.harmony.niochar.charset.ISO_8859_1$Encoder)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    _r3_o = n3;
    ((global::org.apache.harmony.niochar.charset.ISO_18859_11_2Encoder) _r0_o).@this((global::org.apache.harmony.niochar.charset.ISO_18859_11) _r1_o, (global::java.nio.charset.Charset) _r2_o);
    return;
//XMLVM_END_WRAPPER[org.apache.harmony.niochar.charset.ISO_8859_1$Encoder: void <init>(org.apache.harmony.niochar.charset.ISO_8859_1, java.nio.charset.Charset, org.apache.harmony.niochar.charset.ISO_8859_1$Encoder)]
}

//XMLVM_BEGIN_WRAPPER[org.apache.harmony.niochar.charset.ISO_8859_1$Encoder]
//XMLVM_END_WRAPPER[org.apache.harmony.niochar.charset.ISO_8859_1$Encoder]

} // end of class: ISO_18859_11_2Encoder

} // end of namespace: org.apache.harmony.niochar.charset
