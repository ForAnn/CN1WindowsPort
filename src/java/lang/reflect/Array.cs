// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.lang.reflect {
public class Array: global::java.lang.Object {
private void @this(){
//XMLVM_BEGIN_WRAPPER[java.lang.reflect.Array: void <init>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[java.lang.reflect.Array: void <init>()]
}

private static global::System.Object multiNewArrayImpl(global::java.lang.Class n1, int n2, global::org.xmlvm._nArrayAdapter<int> n3){
//XMLVM_BEGIN_WRAPPER[java.lang.reflect.Array: java.lang.Object multiNewArrayImpl(java.lang.Class, int, int[])]
      throw new org.xmlvm._nNotYetImplementedException("native/wrapper method not yet implemented");
//XMLVM_END_WRAPPER[java.lang.reflect.Array: java.lang.Object multiNewArrayImpl(java.lang.Class, int, int[])]
}

private static global::System.Object newArrayImpl(global::java.lang.Class n1, int n2){
//XMLVM_BEGIN_WRAPPER[java.lang.reflect.Array: java.lang.Object newArrayImpl(java.lang.Class, int)]
      throw new org.xmlvm._nNotYetImplementedException("native/wrapper method not yet implemented");
//XMLVM_END_WRAPPER[java.lang.reflect.Array: java.lang.Object newArrayImpl(java.lang.Class, int)]
}

public static global::System.Object get(global::java.lang.Object n1, int n2){
//XMLVM_BEGIN_WRAPPER[java.lang.reflect.Array: java.lang.Object get(java.lang.Object, int)]
    throw new org.xmlvm._nNotYetImplementedException("native/wrapper method not yet implemented");
    if (n1==null) {
        java.lang.NullPointerException jex = new java.lang.NullPointerException();
        jex.@this();
        throw new org.xmlvm._nExceptionAdapter(jex);
    } else if (n1 is org.xmlvm._nArrayAdapter<object>) {
        return ((org.xmlvm._nArrayAdapter<object>) n1)[n2];
    } else if (n1 is org.xmlvm._nArrayAdapter<bool>) {
        bool unwrappedBoolean = ((org.xmlvm._nArrayAdapter<bool>) n1)[n2];
        java.lang.Boolean result = new java.lang.Boolean();
        result.@this(unwrappedBoolean);
        return result;
    } else if (n1 is org.xmlvm._nArrayAdapter<sbyte>) {
        sbyte unwrappedByte = ((org.xmlvm._nArrayAdapter<sbyte>) n1)[n2];
        java.lang.Byte result = new java.lang.Byte();
        result.@this(unwrappedByte);
        return result;
    } else if (n1 is org.xmlvm._nArrayAdapter<char>) {
        char unwrappedChar = ((org.xmlvm._nArrayAdapter<char>) n1)[n2];
        java.lang.Character result = new java.lang.Character();
        result.@this(unwrappedChar);
        return result;
    } else if (n1 is org.xmlvm._nArrayAdapter<short>) {
        short unwrappedShort = ((org.xmlvm._nArrayAdapter<short>) n1)[n2];
        java.lang.Short result = new java.lang.Short();
        result.@this(unwrappedShort);
        return result;
    } else if (n1 is org.xmlvm._nArrayAdapter<int>) {
        int unwrappedInteger = ((org.xmlvm._nArrayAdapter<int>) n1)[n2];
        java.lang.Integer result = new java.lang.Integer();
        result.@this(unwrappedInteger);
        return result;
    } else if (n1 is org.xmlvm._nArrayAdapter<long>) {
        long unwrappedLong = ((org.xmlvm._nArrayAdapter<long>) n1)[n2];
        java.lang.Long result = new java.lang.Long();
        result.@this(unwrappedLong);
        return result;
    } else if (n1 is org.xmlvm._nArrayAdapter<float>) {
        float unwrappedFloat = ((org.xmlvm._nArrayAdapter<float>) n1)[n2];
        java.lang.Float result = new java.lang.Float();
        result.@this(unwrappedFloat);
        return result;
    } else if (n1 is org.xmlvm._nArrayAdapter<double>) {
        double unwrappedDouble = ((org.xmlvm._nArrayAdapter<double>) n1)[n2];
        java.lang.Double result = new java.lang.Double();
        result.@this(unwrappedDouble);
        return result;
    } else if (!(n1 is org.xmlvm._nIArray)) {
        // it is not an org.xmlvm._nIArray 
        java.lang.IllegalArgumentException jex = new java.lang.IllegalArgumentException();
        jex.@this(org.xmlvm._nUtil.toJavaString("Not an array"));
        throw new org.xmlvm._nExceptionAdapter(jex);
    } else {
        // something went wrong
        throw new org.xmlvm._nNativeImplementationException();
    }
//XMLVM_END_WRAPPER[java.lang.reflect.Array: java.lang.Object get(java.lang.Object, int)]
}

public static bool getBoolean(global::java.lang.Object n1, int n2){
//XMLVM_BEGIN_WRAPPER[java.lang.reflect.Array: boolean getBoolean(java.lang.Object, int)]
    throw new org.xmlvm._nNotYetImplementedException("native/wrapper method not yet implemented");
    if (n1==null) {
        java.lang.NullPointerException jex = new java.lang.NullPointerException();
        jex.@this();
        throw new org.xmlvm._nExceptionAdapter(jex);
    } else if (n1 is org.xmlvm._nArrayAdapter<bool>) {
        return ((org.xmlvm._nArrayAdapter<bool>) n1)[n2];
    } else {
        // either it is not an org.xmlvm._nIArray 
        //   or the non-identity conversion is not allowed, 
        //   since there is no allowed widening conversions into boolean for the component type:
        java.lang.IllegalArgumentException jex = new java.lang.IllegalArgumentException();
        jex.@this();
        throw new org.xmlvm._nExceptionAdapter(jex);
    }

//XMLVM_END_WRAPPER[java.lang.reflect.Array: boolean getBoolean(java.lang.Object, int)]
}

public static sbyte getByte(global::java.lang.Object n1, int n2){
//XMLVM_BEGIN_WRAPPER[java.lang.reflect.Array: byte getByte(java.lang.Object, int)]
    throw new org.xmlvm._nNotYetImplementedException("native/wrapper method not yet implemented");
    if (n1==null) {
        java.lang.NullPointerException jex = new java.lang.NullPointerException();
        jex.@this();
        throw new org.xmlvm._nExceptionAdapter(jex);
    } else if (n1 is org.xmlvm._nArrayAdapter<sbyte>) {
        return ((org.xmlvm._nArrayAdapter<sbyte>) n1)[n2];
    } else {
        // either it is not an org.xmlvm._nIArray 
        //   or the non-identity conversion is not allowed, 
        //   since there is no allowed widening conversions into byte for the component type:
        java.lang.IllegalArgumentException jex = new java.lang.IllegalArgumentException();
        jex.@this();
        throw new org.xmlvm._nExceptionAdapter(jex);
    }
//XMLVM_END_WRAPPER[java.lang.reflect.Array: byte getByte(java.lang.Object, int)]
}

public static char getChar(global::java.lang.Object n1, int n2){
//XMLVM_BEGIN_WRAPPER[java.lang.reflect.Array: char getChar(java.lang.Object, int)]
    throw new org.xmlvm._nNotYetImplementedException("native/wrapper method not yet implemented");
    if (n1==null) {
        java.lang.NullPointerException jex = new java.lang.NullPointerException();
        jex.@this();
        throw new org.xmlvm._nExceptionAdapter(jex);
    } else if (n1 is org.xmlvm._nArrayAdapter<char>) {
        return ((org.xmlvm._nArrayAdapter<char>) n1)[n2];
    } else {
        // either it is not an org.xmlvm._nIArray 
        //   or the non-identity conversion is not allowed, 
        //   since there is no allowed widening conversions into char for the component type:
        java.lang.IllegalArgumentException jex = new java.lang.IllegalArgumentException();
        jex.@this();
        throw new org.xmlvm._nExceptionAdapter(jex);
    }
//XMLVM_END_WRAPPER[java.lang.reflect.Array: char getChar(java.lang.Object, int)]
}

public static double getDouble(global::java.lang.Object n1, int n2){
//XMLVM_BEGIN_WRAPPER[java.lang.reflect.Array: double getDouble(java.lang.Object, int)]
    throw new org.xmlvm._nNotYetImplementedException("native/wrapper method not yet implemented");
    if (n1==null) {
        java.lang.NullPointerException jex = new java.lang.NullPointerException();
        jex.@this();
        throw new org.xmlvm._nExceptionAdapter(jex);
    } else if (n1 is org.xmlvm._nArrayAdapter<sbyte>) {
        return ((org.xmlvm._nArrayAdapter<sbyte>) n1)[n2];
    } else if (n1 is org.xmlvm._nArrayAdapter<char>) {
        return ((org.xmlvm._nArrayAdapter<char>) n1)[n2];
    } else if (n1 is org.xmlvm._nArrayAdapter<short>) {
        return ((org.xmlvm._nArrayAdapter<short>) n1)[n2];
    } else if (n1 is org.xmlvm._nArrayAdapter<int>) {
        return ((org.xmlvm._nArrayAdapter<int>) n1)[n2];
    } else if (n1 is org.xmlvm._nArrayAdapter<long>) {
        return ((org.xmlvm._nArrayAdapter<long>) n1)[n2];
    } else if (n1 is org.xmlvm._nArrayAdapter<float>) {
        return ((org.xmlvm._nArrayAdapter<float>) n1)[n2];
    } else if (n1 is org.xmlvm._nArrayAdapter<double>) {
        return ((org.xmlvm._nArrayAdapter<double>) n1)[n2];
    } else {
        // if it is not an org.xmlvm._nIArray 
        //   or none of the allowed identity or widening conversions for the component type exists:
        //   double <-- byte, char, short, int, long, float(, double)
        java.lang.IllegalArgumentException jex = new java.lang.IllegalArgumentException();
        jex.@this();
        throw new org.xmlvm._nExceptionAdapter(jex);
    }
//XMLVM_END_WRAPPER[java.lang.reflect.Array: double getDouble(java.lang.Object, int)]
}

public static float getFloat(global::java.lang.Object n1, int n2){
//XMLVM_BEGIN_WRAPPER[java.lang.reflect.Array: float getFloat(java.lang.Object, int)]
    throw new org.xmlvm._nNotYetImplementedException("native/wrapper method not yet implemented");
    if (n1==null) {
        java.lang.NullPointerException jex = new java.lang.NullPointerException();
        jex.@this();
        throw new org.xmlvm._nExceptionAdapter(jex);
    } else if (n1 is org.xmlvm._nArrayAdapter<sbyte>) {
        return ((org.xmlvm._nArrayAdapter<sbyte>) n1)[n2];
    } else if (n1 is org.xmlvm._nArrayAdapter<char>) {
        return ((org.xmlvm._nArrayAdapter<char>) n1)[n2];
    } else if (n1 is org.xmlvm._nArrayAdapter<short>) {
        return ((org.xmlvm._nArrayAdapter<short>) n1)[n2];
    } else if (n1 is org.xmlvm._nArrayAdapter<int>) {
        return ((org.xmlvm._nArrayAdapter<int>) n1)[n2];
    } else if (n1 is org.xmlvm._nArrayAdapter<long>) {
        return ((org.xmlvm._nArrayAdapter<long>) n1)[n2];
    } else if (n1 is org.xmlvm._nArrayAdapter<float>) {
        return ((org.xmlvm._nArrayAdapter<float>) n1)[n2];
    } else {
        // if it is not an org.xmlvm._nIArray 
        //   or none of the allowed identity or widening conversions for the component type exists:
        //   float <-- byte, char, short, int, long(, float)
        java.lang.IllegalArgumentException jex = new java.lang.IllegalArgumentException();
        jex.@this();
        throw new org.xmlvm._nExceptionAdapter(jex);
    }
//XMLVM_END_WRAPPER[java.lang.reflect.Array: float getFloat(java.lang.Object, int)]
}

public static int getInt(global::java.lang.Object n1, int n2){
//XMLVM_BEGIN_WRAPPER[java.lang.reflect.Array: int getInt(java.lang.Object, int)]
    throw new org.xmlvm._nNotYetImplementedException("native/wrapper method not yet implemented");
    if (n1==null) {
        java.lang.NullPointerException jex = new java.lang.NullPointerException();
        jex.@this();
        throw new org.xmlvm._nExceptionAdapter(jex);
    } else if (n1 is org.xmlvm._nArrayAdapter<sbyte>) {
        return ((org.xmlvm._nArrayAdapter<sbyte>) n1)[n2];
    } else if (n1 is org.xmlvm._nArrayAdapter<char>) {
        return ((org.xmlvm._nArrayAdapter<char>) n1)[n2];
    } else if (n1 is org.xmlvm._nArrayAdapter<short>) {
        return ((org.xmlvm._nArrayAdapter<short>) n1)[n2];
    } else if (n1 is org.xmlvm._nArrayAdapter<int>) {
        return ((org.xmlvm._nArrayAdapter<int>) n1)[n2];
    } else {
        // if it is not an org.xmlvm._nIArray 
        //   or none of the allowed identity or widening conversions for the component type exists:
        //   int <-- byte, char, short(, int)
        java.lang.IllegalArgumentException jex = new java.lang.IllegalArgumentException();
        jex.@this();
        throw new org.xmlvm._nExceptionAdapter(jex);
    }
//XMLVM_END_WRAPPER[java.lang.reflect.Array: int getInt(java.lang.Object, int)]
}

public static int getLength(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.lang.reflect.Array: int getLength(java.lang.Object)]
    throw new org.xmlvm._nNotYetImplementedException("native/wrapper method not yet implemented");
    if (n1==null) {
        java.lang.NullPointerException jex = new java.lang.NullPointerException();
        jex.@this();
        throw new org.xmlvm._nExceptionAdapter(jex);
    } else if (!(n1 is org.xmlvm._nIArray)) {
        // if it is not an org.xmlvm._nIArray 
        java.lang.IllegalArgumentException jex = new java.lang.IllegalArgumentException();
        jex.@this();
        throw new org.xmlvm._nExceptionAdapter(jex);
    } else {
        return ((org.xmlvm._nIArray) n1).Length;
    }    
//XMLVM_END_WRAPPER[java.lang.reflect.Array: int getLength(java.lang.Object)]
}

public static long getLong(global::java.lang.Object n1, int n2){
//XMLVM_BEGIN_WRAPPER[java.lang.reflect.Array: long getLong(java.lang.Object, int)]
    throw new org.xmlvm._nNotYetImplementedException("native/wrapper method not yet implemented");
    if (n1==null) {
        java.lang.NullPointerException jex = new java.lang.NullPointerException();
        jex.@this();
        throw new org.xmlvm._nExceptionAdapter(jex);
    } else if (n1 is org.xmlvm._nArrayAdapter<sbyte>) {
        return ((org.xmlvm._nArrayAdapter<sbyte>) n1)[n2];
    } else if (n1 is org.xmlvm._nArrayAdapter<char>) {
        return ((org.xmlvm._nArrayAdapter<char>) n1)[n2];
    } else if (n1 is org.xmlvm._nArrayAdapter<short>) {
        return ((org.xmlvm._nArrayAdapter<short>) n1)[n2];
    } else if (n1 is org.xmlvm._nArrayAdapter<int>) {
        return ((org.xmlvm._nArrayAdapter<int>) n1)[n2];
    } else if (n1 is org.xmlvm._nArrayAdapter<long>) {
        return ((org.xmlvm._nArrayAdapter<long>) n1)[n2];
    } else {
        // if it is not an org.xmlvm._nIArray 
        //   or none of the allowed identity or widening conversions for the component type exists:
        //   long <-- byte, char, short, int(, long)
        java.lang.IllegalArgumentException jex = new java.lang.IllegalArgumentException();
        jex.@this();
        throw new org.xmlvm._nExceptionAdapter(jex);
    }
//XMLVM_END_WRAPPER[java.lang.reflect.Array: long getLong(java.lang.Object, int)]
}

public static short getShort(global::java.lang.Object n1, int n2){
//XMLVM_BEGIN_WRAPPER[java.lang.reflect.Array: short getShort(java.lang.Object, int)]
    throw new org.xmlvm._nNotYetImplementedException("native/wrapper method not yet implemented");
    if (n1==null) {
        java.lang.NullPointerException jex = new java.lang.NullPointerException();
        jex.@this();
        throw new org.xmlvm._nExceptionAdapter(jex);
    } else if (n1 is org.xmlvm._nArrayAdapter<sbyte>) {
        return ((org.xmlvm._nArrayAdapter<sbyte>) n1)[n2];
    } else if (n1 is org.xmlvm._nArrayAdapter<short>) {
        return ((org.xmlvm._nArrayAdapter<short>) n1)[n2];
    } else {
        // if it is not an org.xmlvm._nIArray 
        //   or none of the allowed identity or widening conversions for the component type exists:
        //   short <-- byte(, short)
        java.lang.IllegalArgumentException jex = new java.lang.IllegalArgumentException();
        jex.@this();
        throw new org.xmlvm._nExceptionAdapter(jex);
    }
//XMLVM_END_WRAPPER[java.lang.reflect.Array: short getShort(java.lang.Object, int)]
}

public static global::System.Object newInstance(global::java.lang.Class n1, global::org.xmlvm._nArrayAdapter<int> n2){
//XMLVM_BEGIN_WRAPPER[java.lang.reflect.Array: java.lang.Object newInstance(java.lang.Class, int[])]
      throw new org.xmlvm._nNotYetImplementedException("native/wrapper method not yet implemented");
//XMLVM_END_WRAPPER[java.lang.reflect.Array: java.lang.Object newInstance(java.lang.Class, int[])]
}

public static global::System.Object newInstance(global::java.lang.Class n1, int n2){
//XMLVM_BEGIN_WRAPPER[java.lang.reflect.Array: java.lang.Object newInstance(java.lang.Class, int)]
    global::System.Object[] csharpArray = (global::System.Object[]) global::System.Array.CreateInstance(((org.xmlvm._nTIB)n1._ftib).getNativeType(), n2);
    org.xmlvm._nArrayAdapter<global::System.Object> adapter = new org.xmlvm._nArrayAdapter<global::System.Object>(csharpArray);
    return adapter;
//XMLVM_END_WRAPPER[java.lang.reflect.Array: java.lang.Object newInstance(java.lang.Class, int)]
}

public static void set(global::java.lang.Object n1, int n2, global::java.lang.Object n3){
//XMLVM_BEGIN_WRAPPER[java.lang.reflect.Array: void set(java.lang.Object, int, java.lang.Object)]
    throw new org.xmlvm._nNotYetImplementedException("native/wrapper method not yet implemented");
    if (n1==null) {
        java.lang.NullPointerException jex = new java.lang.NullPointerException();
        jex.@this();
        throw new org.xmlvm._nExceptionAdapter(jex);
    } else if (n1 is org.xmlvm._nArrayAdapter<object>) {
        ((org.xmlvm._nArrayAdapter<object>) n1)[n2] = n3;
        return;
    } else if ((n1 is org.xmlvm._nArrayAdapter<bool>) 
               && (n3 is java.lang.Boolean)) {
        bool unwrappedBoolean = ((java.lang.Boolean) n3).booleanValue();
        ((org.xmlvm._nArrayAdapter<bool>) n1)[n2] = unwrappedBoolean;
        return;
    } else if ((n1 is org.xmlvm._nArrayAdapter<sbyte>)
               && (n3 is java.lang.Byte)){
        sbyte unwrappedByte = ((java.lang.Byte) n3).byteValue();
        ((org.xmlvm._nArrayAdapter<sbyte>) n1)[n2] = unwrappedByte;
        return;
    } else if ((n1 is org.xmlvm._nArrayAdapter<char>)
               && (n3 is java.lang.Character)){
        char unwrappedChar = ((java.lang.Character) n3).charValue();
        ((org.xmlvm._nArrayAdapter<char>) n1)[n2] = unwrappedChar;
        return;
    } else if ((n1 is org.xmlvm._nArrayAdapter<short>)
               && (n3 is java.lang.Short)) {
        short unwrappedShort = ((java.lang.Short) n3).shortValue();
        ((org.xmlvm._nArrayAdapter<short>) n1)[n2] = unwrappedShort;
        return;
    } else if ((n1 is org.xmlvm._nArrayAdapter<int>)
               && (n3 is java.lang.Integer)) {
        int unwrappedInteger = ((java.lang.Integer) n3).intValue();
        ((org.xmlvm._nArrayAdapter<int>) n1)[n2] = unwrappedInteger;
        return;
    } else if ((n1 is org.xmlvm._nArrayAdapter<long>)
               && (n3 is java.lang.Long)) {
        long unwrappedLong = ((java.lang.Long) n3).longValue();
        ((org.xmlvm._nArrayAdapter<long>) n1)[n2] = unwrappedLong;
        return;
    } else if ((n1 is org.xmlvm._nArrayAdapter<float>)
               && (n3 is java.lang.Float)) {
        float unwrappedFloat = ((java.lang.Float) n3).floatValue();
        ((org.xmlvm._nArrayAdapter<float>) n1)[n2] = unwrappedFloat;
        return;
    } else if ((n1 is org.xmlvm._nArrayAdapter<double>)
               && (n3 is java.lang.Double)) {
        double unwrappedDouble = ((java.lang.Double) n3).doubleValue();
        ((org.xmlvm._nArrayAdapter<double>) n1)[n2] = unwrappedDouble;
        return;
    } else {
        // either it is not an org.xmlvm._nIArray 
        //   or the given value cannot be unwrapped to the component type 
        //   of this array
        java.lang.IllegalArgumentException jex = new java.lang.IllegalArgumentException();
        jex.@this(org.xmlvm._nUtil.toJavaString("Not an array"));
        throw new org.xmlvm._nExceptionAdapter(jex);
    }
//XMLVM_END_WRAPPER[java.lang.reflect.Array: void set(java.lang.Object, int, java.lang.Object)]
}

public static void setBoolean(global::java.lang.Object n1, int n2, bool n3){
//XMLVM_BEGIN_WRAPPER[java.lang.reflect.Array: void setBoolean(java.lang.Object, int, boolean)]
    throw new org.xmlvm._nNotYetImplementedException("native/wrapper method not yet implemented");
    if (n1==null) {
        java.lang.NullPointerException jex = new java.lang.NullPointerException();
        jex.@this();
        throw new org.xmlvm._nExceptionAdapter(jex);
    } else if (!(n1 is org.xmlvm._nArrayAdapter<bool>)) {
        // there are no widening conversion allowed here, other than the identity boolean --> boolean
        java.lang.IllegalArgumentException jex = new java.lang.IllegalArgumentException();
        jex.@this();
        throw new org.xmlvm._nExceptionAdapter(jex);
    } else {
        ((org.xmlvm._nArrayAdapter<bool>) n1)[n2] = n3;
        return;
    }
//XMLVM_END_WRAPPER[java.lang.reflect.Array: void setBoolean(java.lang.Object, int, boolean)]
}

public static void setByte(global::java.lang.Object n1, int n2, sbyte n3){
//XMLVM_BEGIN_WRAPPER[java.lang.reflect.Array: void setByte(java.lang.Object, int, byte)]
    throw new org.xmlvm._nNotYetImplementedException("native/wrapper method not yet implemented");
    if (n1==null) {
        java.lang.NullPointerException jex = new java.lang.NullPointerException();
        jex.@this();
        throw new org.xmlvm._nExceptionAdapter(jex);
    } else if (n1 is org.xmlvm._nArrayAdapter<sbyte>) {
        ((org.xmlvm._nArrayAdapter<sbyte>) n1)[n2] = n3;
        return;
    } else if (n1 is org.xmlvm._nArrayAdapter<short>) {
        ((org.xmlvm._nArrayAdapter<short>) n1)[n2] = n3;
        return;
    } else if (n1 is org.xmlvm._nArrayAdapter<int>) {
        ((org.xmlvm._nArrayAdapter<int>) n1)[n2] = n3;
        return;
    } else if (n1 is org.xmlvm._nArrayAdapter<long>) {
        ((org.xmlvm._nArrayAdapter<long>) n1)[n2] = n3;
        return;
    } else if (n1 is org.xmlvm._nArrayAdapter<float>) {
        ((org.xmlvm._nArrayAdapter<float>) n1)[n2] = n3;
        return;
    } else if (n1 is org.xmlvm._nArrayAdapter<double>) {
        ((org.xmlvm._nArrayAdapter<double>) n1)[n2] = n3;
        return;
    } else {
        // if it is not an org.xmlvm._nIArray 
        //   or none of the allowed identity or widening conversions for the component type exists:
        //   byte --> (byte, )short, int, long, float, double
        java.lang.IllegalArgumentException jex = new java.lang.IllegalArgumentException();
        jex.@this();
        throw new org.xmlvm._nExceptionAdapter(jex);
    }
//XMLVM_END_WRAPPER[java.lang.reflect.Array: void setByte(java.lang.Object, int, byte)]
}

public static void setChar(global::java.lang.Object n1, int n2, char n3){
//XMLVM_BEGIN_WRAPPER[java.lang.reflect.Array: void setChar(java.lang.Object, int, char)]
    throw new org.xmlvm._nNotYetImplementedException("native/wrapper method not yet implemented");
    if (n1==null) {
        java.lang.NullPointerException jex = new java.lang.NullPointerException();
        jex.@this();
        throw new org.xmlvm._nExceptionAdapter(jex);
    } else if (n1 is org.xmlvm._nArrayAdapter<char>) {
        ((org.xmlvm._nArrayAdapter<char>) n1)[n2] = n3;
        return;
    } else if (n1 is org.xmlvm._nArrayAdapter<int>) {
        ((org.xmlvm._nArrayAdapter<int>) n1)[n2] = n3;
        return;
    } else if (n1 is org.xmlvm._nArrayAdapter<long>) {
        ((org.xmlvm._nArrayAdapter<long>) n1)[n2] = n3;
        return;
    } else if (n1 is org.xmlvm._nArrayAdapter<float>) {
        ((org.xmlvm._nArrayAdapter<float>) n1)[n2] = n3;
        return;
    } else if (n1 is org.xmlvm._nArrayAdapter<double>) {
        ((org.xmlvm._nArrayAdapter<double>) n1)[n2] = n3;
        return;
    } else {
        // if it is not an org.xmlvm._nIArray 
        //  or none of the allowed identity or widening conversions exists for the component type:
        //   char --> (char, )int, long, float, double
        java.lang.IllegalArgumentException jex = new java.lang.IllegalArgumentException();
        jex.@this();
        throw new org.xmlvm._nExceptionAdapter(jex);
    }
//XMLVM_END_WRAPPER[java.lang.reflect.Array: void setChar(java.lang.Object, int, char)]
}

public static void setDouble(global::java.lang.Object n1, int n2, double n3){
//XMLVM_BEGIN_WRAPPER[java.lang.reflect.Array: void setDouble(java.lang.Object, int, double)]
    throw new org.xmlvm._nNotYetImplementedException("native/wrapper method not yet implemented");
    if (n1==null) {
        java.lang.NullPointerException jex = new java.lang.NullPointerException();
        jex.@this();
        throw new org.xmlvm._nExceptionAdapter(jex);
    } else if (n1 is org.xmlvm._nArrayAdapter<double>) {
        ((org.xmlvm._nArrayAdapter<double>) n1)[n2] = n3;
        return;
    } else {
        // if it is not an org.xmlvm._nIArray or its component type differs from double
        //   (since there are no widening conversions allowed for double)
        java.lang.IllegalArgumentException jex = new java.lang.IllegalArgumentException();
        jex.@this();
        throw new org.xmlvm._nExceptionAdapter(jex);
    }
//XMLVM_END_WRAPPER[java.lang.reflect.Array: void setDouble(java.lang.Object, int, double)]
}

public static void setFloat(global::java.lang.Object n1, int n2, float n3){
//XMLVM_BEGIN_WRAPPER[java.lang.reflect.Array: void setFloat(java.lang.Object, int, float)]
    throw new org.xmlvm._nNotYetImplementedException("native/wrapper method not yet implemented");
    if (n1==null) {
        java.lang.NullPointerException jex = new java.lang.NullPointerException();
        jex.@this();
        throw new org.xmlvm._nExceptionAdapter(jex);
    } else if (n1 is org.xmlvm._nArrayAdapter<float>) {
        ((org.xmlvm._nArrayAdapter<float>) n1)[n2] = n3;
        return;
    } else if (n1 is org.xmlvm._nArrayAdapter<double>) {
        ((org.xmlvm._nArrayAdapter<double>) n1)[n2] = n3;
        return;
    } else {
        // if it is not an org.xmlvm._nIArray 
        //  or none of the allowed identity or widening conversions for the component type:
        //   float --> (float, )double
        java.lang.IllegalArgumentException jex = new java.lang.IllegalArgumentException();
        jex.@this();
        throw new org.xmlvm._nExceptionAdapter(jex);
    }
//XMLVM_END_WRAPPER[java.lang.reflect.Array: void setFloat(java.lang.Object, int, float)]
}

public static void setInt(global::java.lang.Object n1, int n2, int n3){
//XMLVM_BEGIN_WRAPPER[java.lang.reflect.Array: void setInt(java.lang.Object, int, int)]
    throw new org.xmlvm._nNotYetImplementedException("native/wrapper method not yet implemented");
    if (n1==null) {
        java.lang.NullPointerException jex = new java.lang.NullPointerException();
        jex.@this();
        throw new org.xmlvm._nExceptionAdapter(jex);
    } else if (n1 is org.xmlvm._nArrayAdapter<int>) {
        ((org.xmlvm._nArrayAdapter<int>) n1)[n2] = n3;
        return;
    } else if (n1 is org.xmlvm._nArrayAdapter<long>) {
        ((org.xmlvm._nArrayAdapter<long>) n1)[n2] = n3;
        return;
    } else if (n1 is org.xmlvm._nArrayAdapter<float>) {
        ((org.xmlvm._nArrayAdapter<float>) n1)[n2] = n3;
        return;
    } else if (n1 is org.xmlvm._nArrayAdapter<double>) {
        ((org.xmlvm._nArrayAdapter<double>) n1)[n2] = n3;
        return;
    } else {
        // if it is not an org.xmlvm._nIArray 
        //   or none of the allowed identity or widening conversions for the component type:
        //   int --> (int, )long, float, double
        java.lang.IllegalArgumentException jex = new java.lang.IllegalArgumentException();
        jex.@this();
        throw new org.xmlvm._nExceptionAdapter(jex);
    }
//XMLVM_END_WRAPPER[java.lang.reflect.Array: void setInt(java.lang.Object, int, int)]
}

public static void setLong(global::java.lang.Object n1, int n2, long n3){
//XMLVM_BEGIN_WRAPPER[java.lang.reflect.Array: void setLong(java.lang.Object, int, long)]
    throw new org.xmlvm._nNotYetImplementedException("native/wrapper method not yet implemented");
    if (n1==null) {
        java.lang.NullPointerException jex = new java.lang.NullPointerException();
        jex.@this();
        throw new org.xmlvm._nExceptionAdapter(jex);
    } else if (n1 is org.xmlvm._nArrayAdapter<long>) {
        ((org.xmlvm._nArrayAdapter<long>) n1)[n2] = n3;
        return;
    } else if (n1 is org.xmlvm._nArrayAdapter<float>) {
        ((org.xmlvm._nArrayAdapter<float>) n1)[n2] = n3;
        return;
    } else if (n1 is org.xmlvm._nArrayAdapter<double>) {
        ((org.xmlvm._nArrayAdapter<double>) n1)[n2] = n3;
        return;
    } else {
        // if it is not an org.xmlvm._nIArray 
        //   or none of the allowed identity or widening conversions for the component type:
        //   long --> (long, )float, double
        java.lang.IllegalArgumentException jex = new java.lang.IllegalArgumentException();
        jex.@this();
        throw new org.xmlvm._nExceptionAdapter(jex);
    }
//XMLVM_END_WRAPPER[java.lang.reflect.Array: void setLong(java.lang.Object, int, long)]
}

public static void setShort(global::java.lang.Object n1, int n2, short n3){
//XMLVM_BEGIN_WRAPPER[java.lang.reflect.Array: void setShort(java.lang.Object, int, short)]
    throw new org.xmlvm._nNotYetImplementedException("native/wrapper method not yet implemented");
    if (n1==null) {
        java.lang.NullPointerException jex = new java.lang.NullPointerException();
        jex.@this();
        throw new org.xmlvm._nExceptionAdapter(jex);
    } else if (n1 is org.xmlvm._nArrayAdapter<short>) {
        ((org.xmlvm._nArrayAdapter<short>) n1)[n2] = n3;
        return;
    } else if (n1 is org.xmlvm._nArrayAdapter<int>) {
        ((org.xmlvm._nArrayAdapter<int>) n1)[n2] = n3;
        return;
    } else if (n1 is org.xmlvm._nArrayAdapter<long>) {
        ((org.xmlvm._nArrayAdapter<long>) n1)[n2] = n3;
        return;
    } else if (n1 is org.xmlvm._nArrayAdapter<float>) {
        ((org.xmlvm._nArrayAdapter<float>) n1)[n2] = n3;
        return;
    } else if (n1 is org.xmlvm._nArrayAdapter<double>) {
        ((org.xmlvm._nArrayAdapter<double>) n1)[n2] = n3;
        return;
    } else {
        // if it is not an org.xmlvm._nIArray 
        //   or none of the allowed identity or widening conversions for the component type:
        //   short --> (short, )int, long, float, double
        java.lang.IllegalArgumentException jex = new java.lang.IllegalArgumentException();
        jex.@this();
        throw new org.xmlvm._nExceptionAdapter(jex);
    }
//XMLVM_END_WRAPPER[java.lang.reflect.Array: void setShort(java.lang.Object, int, short)]
}

//XMLVM_BEGIN_WRAPPER[java.lang.reflect.Array]
//XMLVM_END_WRAPPER[java.lang.reflect.Array]

} // end of class: Array

} // end of namespace: java.lang.reflect
