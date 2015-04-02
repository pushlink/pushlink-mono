using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Pushlink.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.pushlink.android']/class[@name='PushLink']"
	[global::Android.Runtime.Register ("com/pushlink/android/PushLink", DoNotGenerateAcw=true)]
	public sealed partial class PushLink : global::Java.Lang.Object {


		static IntPtr apiKey_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.pushlink.android']/class[@name='PushLink']/field[@name='apiKey']"
		[Register ("apiKey")]
		protected static string ApiKey {
			get {
				if (apiKey_jfieldId == IntPtr.Zero)
					apiKey_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "apiKey", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, apiKey_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (apiKey_jfieldId == IntPtr.Zero)
					apiKey_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "apiKey", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetStaticField (class_ref, apiKey_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr context_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.pushlink.android']/class[@name='PushLink']/field[@name='context']"
		[Register ("context")]
		protected static global::Android.Content.Context Context {
			get {
				if (context_jfieldId == IntPtr.Zero)
					context_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "context", "Landroid/content/Context;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, context_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (context_jfieldId == IntPtr.Zero)
					context_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "context", "Landroid/content/Context;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, context_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr deviceId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.pushlink.android']/class[@name='PushLink']/field[@name='deviceId']"
		[Register ("deviceId")]
		protected static string DeviceId {
			get {
				if (deviceId_jfieldId == IntPtr.Zero)
					deviceId_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "deviceId", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, deviceId_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (deviceId_jfieldId == IntPtr.Zero)
					deviceId_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "deviceId", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetStaticField (class_ref, deviceId_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr exceptionNotification_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.pushlink.android']/class[@name='PushLink']/field[@name='exceptionNotification']"
		[Register ("exceptionNotification")]
		protected static bool ExceptionNotification {
			get {
				if (exceptionNotification_jfieldId == IntPtr.Zero)
					exceptionNotification_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "exceptionNotification", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, exceptionNotification_jfieldId);
			}
			set {
				if (exceptionNotification_jfieldId == IntPtr.Zero)
					exceptionNotification_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "exceptionNotification", "Z");
				JNIEnv.SetStaticField (class_ref, exceptionNotification_jfieldId, value);
			}
		}

		static IntPtr host_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.pushlink.android']/class[@name='PushLink']/field[@name='host']"
		[Register ("host")]
		protected static string Host {
			get {
				if (host_jfieldId == IntPtr.Zero)
					host_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "host", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, host_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (host_jfieldId == IntPtr.Zero)
					host_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "host", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetStaticField (class_ref, host_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr httpPort_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.pushlink.android']/class[@name='PushLink']/field[@name='httpPort']"
		[Register ("httpPort")]
		protected static int HttpPort {
			get {
				if (httpPort_jfieldId == IntPtr.Zero)
					httpPort_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "httpPort", "I");
				return JNIEnv.GetStaticIntField (class_ref, httpPort_jfieldId);
			}
			set {
				if (httpPort_jfieldId == IntPtr.Zero)
					httpPort_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "httpPort", "I");
				JNIEnv.SetStaticField (class_ref, httpPort_jfieldId, value);
			}
		}

		static IntPtr metadata_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.pushlink.android']/class[@name='PushLink']/field[@name='metadata']"
		[Register ("metadata")]
		protected static global::System.Collections.IDictionary Metadata {
			get {
				if (metadata_jfieldId == IntPtr.Zero)
					metadata_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "metadata", "Ljava/util/HashMap;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, metadata_jfieldId);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (metadata_jfieldId == IntPtr.Zero)
					metadata_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "metadata", "Ljava/util/HashMap;");
				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, metadata_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr pushLinkVersion_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.pushlink.android']/class[@name='PushLink']/field[@name='pushLinkVersion']"
		[Register ("pushLinkVersion")]
		protected static string PushLinkVersion {
			get {
				if (pushLinkVersion_jfieldId == IntPtr.Zero)
					pushLinkVersion_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "pushLinkVersion", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, pushLinkVersion_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (pushLinkVersion_jfieldId == IntPtr.Zero)
					pushLinkVersion_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "pushLinkVersion", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetStaticField (class_ref, pushLinkVersion_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr rootView_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.pushlink.android']/class[@name='PushLink']/field[@name='rootView']"
		[Register ("rootView")]
		protected static global::Android.Views.View RootView {
			get {
				if (rootView_jfieldId == IntPtr.Zero)
					rootView_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "rootView", "Landroid/view/View;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, rootView_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Views.View> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (rootView_jfieldId == IntPtr.Zero)
					rootView_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "rootView", "Landroid/view/View;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, rootView_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr tcpPort_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.pushlink.android']/class[@name='PushLink']/field[@name='tcpPort']"
		[Register ("tcpPort")]
		protected static int TcpPort {
			get {
				if (tcpPort_jfieldId == IntPtr.Zero)
					tcpPort_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "tcpPort", "I");
				return JNIEnv.GetStaticIntField (class_ref, tcpPort_jfieldId);
			}
			set {
				if (tcpPort_jfieldId == IntPtr.Zero)
					tcpPort_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "tcpPort", "I");
				JNIEnv.SetStaticField (class_ref, tcpPort_jfieldId, value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/pushlink/android/PushLink", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PushLink); }
		}

		internal PushLink (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getCurrentStrategy;
		public static global::Com.Pushlink.Android.Strategy CurrentStrategy {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pushlink.android']/class[@name='PushLink']/method[@name='getCurrentStrategy' and count(parameter)=0]"
			[Register ("getCurrentStrategy", "()Lcom/pushlink/android/Strategy;", "GetGetCurrentStrategyHandler")]
			get {
				if (id_getCurrentStrategy == IntPtr.Zero)
					id_getCurrentStrategy = JNIEnv.GetStaticMethodID (class_ref, "getCurrentStrategy", "()Lcom/pushlink/android/Strategy;");
				return global::Java.Lang.Object.GetObject<global::Com.Pushlink.Android.Strategy> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getCurrentStrategy), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_hasPengingUpdate;
		public static bool HasPengingUpdate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pushlink.android']/class[@name='PushLink']/method[@name='hasPengingUpdate' and count(parameter)=0]"
			[Register ("hasPengingUpdate", "()Z", "GetHasPengingUpdateHandler")]
			get {
				if (id_hasPengingUpdate == IntPtr.Zero)
					id_hasPengingUpdate = JNIEnv.GetStaticMethodID (class_ref, "hasPengingUpdate", "()Z");
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_hasPengingUpdate);
			}
		}

		static IntPtr id_addExceptionMetadata_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pushlink.android']/class[@name='PushLink']/method[@name='addExceptionMetadata' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("addExceptionMetadata", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static void AddExceptionMetadata (string p0, string p1)
		{
			if (id_addExceptionMetadata_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_addExceptionMetadata_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "addExceptionMetadata", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_addExceptionMetadata_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_addMetadata_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pushlink.android']/class[@name='PushLink']/method[@name='addMetadata' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("addMetadata", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static void AddMetadata (string p0, string p1)
		{
			if (id_addMetadata_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_addMetadata_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "addMetadata", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_addMetadata_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_disableExceptionNotification;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pushlink.android']/class[@name='PushLink']/method[@name='disableExceptionNotification' and count(parameter)=0]"
		[Register ("disableExceptionNotification", "()V", "")]
		public static void DisableExceptionNotification ()
		{
			if (id_disableExceptionNotification == IntPtr.Zero)
				id_disableExceptionNotification = JNIEnv.GetStaticMethodID (class_ref, "disableExceptionNotification", "()V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_disableExceptionNotification);
		}

		static IntPtr id_enableExceptionNotification;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pushlink.android']/class[@name='PushLink']/method[@name='enableExceptionNotification' and count(parameter)=0]"
		[Register ("enableExceptionNotification", "()V", "")]
		public static void EnableExceptionNotification ()
		{
			if (id_enableExceptionNotification == IntPtr.Zero)
				id_enableExceptionNotification = JNIEnv.GetStaticMethodID (class_ref, "enableExceptionNotification", "()V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_enableExceptionNotification);
		}

		static IntPtr id_idle_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pushlink.android']/class[@name='PushLink']/method[@name='idle' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("idle", "(Z)V", "")]
		public static void Idle (bool p0)
		{
			if (id_idle_Z == IntPtr.Zero)
				id_idle_Z = JNIEnv.GetStaticMethodID (class_ref, "idle", "(Z)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_idle_Z, new JValue (p0));
		}

		static IntPtr id_sendAsyncException_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pushlink.android']/class[@name='PushLink']/method[@name='sendAsyncException' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("sendAsyncException", "(Ljava/lang/Throwable;)V", "")]
		public static void SendAsyncException (global::Java.Lang.Throwable p0)
		{
			if (id_sendAsyncException_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_sendAsyncException_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "sendAsyncException", "(Ljava/lang/Throwable;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_sendAsyncException_Ljava_lang_Throwable_, new JValue (p0));
		}

		static IntPtr id_sendAsyncException_Ljava_lang_Throwable_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pushlink.android']/class[@name='PushLink']/method[@name='sendAsyncException' and count(parameter)=2 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='java.util.Map']]"
		[Register ("sendAsyncException", "(Ljava/lang/Throwable;Ljava/util/Map;)V", "")]
		public static void SendAsyncException (global::Java.Lang.Throwable p0, global::System.Collections.Generic.IDictionary<string, string> p1)
		{
			if (id_sendAsyncException_Ljava_lang_Throwable_Ljava_util_Map_ == IntPtr.Zero)
				id_sendAsyncException_Ljava_lang_Throwable_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "sendAsyncException", "(Ljava/lang/Throwable;Ljava/util/Map;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_sendAsyncException_Ljava_lang_Throwable_Ljava_util_Map_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_setCurrentActivity_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pushlink.android']/class[@name='PushLink']/method[@name='setCurrentActivity' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("setCurrentActivity", "(Landroid/app/Activity;)V", "")]
		public static void SetCurrentActivity (global::Android.App.Activity p0)
		{
			if (id_setCurrentActivity_Landroid_app_Activity_ == IntPtr.Zero)
				id_setCurrentActivity_Landroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "setCurrentActivity", "(Landroid/app/Activity;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setCurrentActivity_Landroid_app_Activity_, new JValue (p0));
		}

		static IntPtr id_setCurrentStrategy_Lcom_pushlink_android_StrategyEnum_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pushlink.android']/class[@name='PushLink']/method[@name='setCurrentStrategy' and count(parameter)=1 and parameter[1][@type='com.pushlink.android.StrategyEnum']]"
		[Register ("setCurrentStrategy", "(Lcom/pushlink/android/StrategyEnum;)V", "")]
		public static void SetCurrentStrategy (global::Com.Pushlink.Android.StrategyEnum p0)
		{
			if (id_setCurrentStrategy_Lcom_pushlink_android_StrategyEnum_ == IntPtr.Zero)
				id_setCurrentStrategy_Lcom_pushlink_android_StrategyEnum_ = JNIEnv.GetStaticMethodID (class_ref, "setCurrentStrategy", "(Lcom/pushlink/android/StrategyEnum;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setCurrentStrategy_Lcom_pushlink_android_StrategyEnum_, new JValue (p0));
		}

		static IntPtr id_start_Landroid_content_Context_ILjava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pushlink.android']/class[@name='PushLink']/method[@name='start' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("start", "(Landroid/content/Context;ILjava/lang/String;Ljava/lang/String;)V", "")]
		public static void Start (global::Android.Content.Context p0, int p1, string p2, string p3)
		{
			if (id_start_Landroid_content_Context_ILjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_start_Landroid_content_Context_ILjava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "start", "(Landroid/content/Context;ILjava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_start_Landroid_content_Context_ILjava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (p1), new JValue (native_p2), new JValue (native_p3));
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
		}

	}
}
