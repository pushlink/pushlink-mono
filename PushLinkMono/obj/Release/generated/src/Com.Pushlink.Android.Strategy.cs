using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Pushlink.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.pushlink.android']/class[@name='Strategy']"
	[global::Android.Runtime.Register ("com/pushlink/android/Strategy", DoNotGenerateAcw=true)]
	public abstract partial class Strategy : global::Java.Lang.Object {


		static IntPtr appName_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.pushlink.android']/class[@name='Strategy']/field[@name='appName']"
		[Register ("appName")]
		protected string AppName {
			get {
				if (appName_jfieldId == IntPtr.Zero)
					appName_jfieldId = JNIEnv.GetFieldID (class_ref, "appName", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, appName_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (appName_jfieldId == IntPtr.Zero)
					appName_jfieldId = JNIEnv.GetFieldID (class_ref, "appName", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, appName_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/pushlink/android/Strategy", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Strategy); }
		}

		protected Strategy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.pushlink.android']/class[@name='Strategy']/constructor[@name='Strategy' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected Strategy () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Strategy)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
		}

		static Delegate cb_getHash;
#pragma warning disable 0169
		static Delegate GetGetHashHandler ()
		{
			if (cb_getHash == null)
				cb_getHash = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHash);
			return cb_getHash;
		}

		static IntPtr n_GetHash (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Pushlink.Android.Strategy __this = global::Java.Lang.Object.GetObject<global::Com.Pushlink.Android.Strategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Hash);
		}
#pragma warning restore 0169

		static Delegate cb_setHash_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetHash_Ljava_lang_String_Handler ()
		{
			if (cb_setHash_Ljava_lang_String_ == null)
				cb_setHash_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetHash_Ljava_lang_String_);
			return cb_setHash_Ljava_lang_String_;
		}

		static void n_SetHash_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Pushlink.Android.Strategy __this = global::Java.Lang.Object.GetObject<global::Com.Pushlink.Android.Strategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Hash = p0;
		}
#pragma warning restore 0169

		protected abstract string Hash {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pushlink.android']/class[@name='Strategy']/method[@name='getHash' and count(parameter)=0]"
			[Register ("getHash", "()Ljava/lang/String;", "GetGetHashHandler")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pushlink.android']/class[@name='Strategy']/method[@name='setHash' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setHash", "(Ljava/lang/String;)V", "GetSetHash_Ljava_lang_String_Handler")] set;
		}

		static Delegate cb_isAnnoyingPopUpStrategy;
#pragma warning disable 0169
		static Delegate GetIsAnnoyingPopUpStrategyHandler ()
		{
			if (cb_isAnnoyingPopUpStrategy == null)
				cb_isAnnoyingPopUpStrategy = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAnnoyingPopUpStrategy);
			return cb_isAnnoyingPopUpStrategy;
		}

		static bool n_IsAnnoyingPopUpStrategy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Pushlink.Android.Strategy __this = global::Java.Lang.Object.GetObject<global::Com.Pushlink.Android.Strategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAnnoyingPopUpStrategy;
		}
#pragma warning restore 0169

		static IntPtr id_isAnnoyingPopUpStrategy;
		protected virtual bool IsAnnoyingPopUpStrategy {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pushlink.android']/class[@name='Strategy']/method[@name='isAnnoyingPopUpStrategy' and count(parameter)=0]"
			[Register ("isAnnoyingPopUpStrategy", "()Z", "GetIsAnnoyingPopUpStrategyHandler")]
			get {
				if (id_isAnnoyingPopUpStrategy == IntPtr.Zero)
					id_isAnnoyingPopUpStrategy = JNIEnv.GetMethodID (class_ref, "isAnnoyingPopUpStrategy", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isAnnoyingPopUpStrategy);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isAnnoyingPopUpStrategy", "()Z"));
			}
		}

		static Delegate cb_isFriendlyPopUpStrategy;
#pragma warning disable 0169
		static Delegate GetIsFriendlyPopUpStrategyHandler ()
		{
			if (cb_isFriendlyPopUpStrategy == null)
				cb_isFriendlyPopUpStrategy = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsFriendlyPopUpStrategy);
			return cb_isFriendlyPopUpStrategy;
		}

		static bool n_IsFriendlyPopUpStrategy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Pushlink.Android.Strategy __this = global::Java.Lang.Object.GetObject<global::Com.Pushlink.Android.Strategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsFriendlyPopUpStrategy;
		}
#pragma warning restore 0169

		static IntPtr id_isFriendlyPopUpStrategy;
		protected virtual bool IsFriendlyPopUpStrategy {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pushlink.android']/class[@name='Strategy']/method[@name='isFriendlyPopUpStrategy' and count(parameter)=0]"
			[Register ("isFriendlyPopUpStrategy", "()Z", "GetIsFriendlyPopUpStrategyHandler")]
			get {
				if (id_isFriendlyPopUpStrategy == IntPtr.Zero)
					id_isFriendlyPopUpStrategy = JNIEnv.GetMethodID (class_ref, "isFriendlyPopUpStrategy", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isFriendlyPopUpStrategy);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isFriendlyPopUpStrategy", "()Z"));
			}
		}

		static Delegate cb_isStatusBarStrategy;
#pragma warning disable 0169
		static Delegate GetIsStatusBarStrategyHandler ()
		{
			if (cb_isStatusBarStrategy == null)
				cb_isStatusBarStrategy = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsStatusBarStrategy);
			return cb_isStatusBarStrategy;
		}

		static bool n_IsStatusBarStrategy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Pushlink.Android.Strategy __this = global::Java.Lang.Object.GetObject<global::Com.Pushlink.Android.Strategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsStatusBarStrategy;
		}
#pragma warning restore 0169

		static IntPtr id_isStatusBarStrategy;
		protected virtual bool IsStatusBarStrategy {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pushlink.android']/class[@name='Strategy']/method[@name='isStatusBarStrategy' and count(parameter)=0]"
			[Register ("isStatusBarStrategy", "()Z", "GetIsStatusBarStrategyHandler")]
			get {
				if (id_isStatusBarStrategy == IntPtr.Zero)
					id_isStatusBarStrategy = JNIEnv.GetMethodID (class_ref, "isStatusBarStrategy", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isStatusBarStrategy);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isStatusBarStrategy", "()Z"));
			}
		}

		static IntPtr id_createStrategy_Lcom_pushlink_android_StrategyEnum_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pushlink.android']/class[@name='Strategy']/method[@name='createStrategy' and count(parameter)=2 and parameter[1][@type='com.pushlink.android.StrategyEnum'] and parameter[2][@type='android.content.Context']]"
		[Register ("createStrategy", "(Lcom/pushlink/android/StrategyEnum;Landroid/content/Context;)Lcom/pushlink/android/Strategy;", "")]
		protected static global::Com.Pushlink.Android.Strategy CreateStrategy (global::Com.Pushlink.Android.StrategyEnum p0, global::Android.Content.Context p1)
		{
			if (id_createStrategy_Lcom_pushlink_android_StrategyEnum_Landroid_content_Context_ == IntPtr.Zero)
				id_createStrategy_Lcom_pushlink_android_StrategyEnum_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "createStrategy", "(Lcom/pushlink/android/StrategyEnum;Landroid/content/Context;)Lcom/pushlink/android/Strategy;");
			global::Com.Pushlink.Android.Strategy __ret = global::Java.Lang.Object.GetObject<global::Com.Pushlink.Android.Strategy> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createStrategy_Lcom_pushlink_android_StrategyEnum_Landroid_content_Context_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_notifyUser_Landroid_content_Intent_Landroid_content_Context_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetNotifyUser_Landroid_content_Intent_Landroid_content_Context_ILjava_lang_String_Handler ()
		{
			if (cb_notifyUser_Landroid_content_Intent_Landroid_content_Context_ILjava_lang_String_ == null)
				cb_notifyUser_Landroid_content_Intent_Landroid_content_Context_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr>) n_NotifyUser_Landroid_content_Intent_Landroid_content_Context_ILjava_lang_String_);
			return cb_notifyUser_Landroid_content_Intent_Landroid_content_Context_ILjava_lang_String_;
		}

		static void n_NotifyUser_Landroid_content_Intent_Landroid_content_Context_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, IntPtr native_p3)
		{
			global::Com.Pushlink.Android.Strategy __this = global::Java.Lang.Object.GetObject<global::Com.Pushlink.Android.Strategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p1, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.NotifyUser (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.pushlink.android']/class[@name='Strategy']/method[@name='notifyUser' and count(parameter)=4 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='android.content.Context'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String']]"
		[Register ("notifyUser", "(Landroid/content/Intent;Landroid/content/Context;ILjava/lang/String;)V", "GetNotifyUser_Landroid_content_Intent_Landroid_content_Context_ILjava_lang_String_Handler")]
		protected abstract void NotifyUser (global::Android.Content.Intent p0, global::Android.Content.Context p1, int p2, string p3);

		static Delegate cb_remind;
#pragma warning disable 0169
		static Delegate GetRemindHandler ()
		{
			if (cb_remind == null)
				cb_remind = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Remind);
			return cb_remind;
		}

		static bool n_Remind (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Pushlink.Android.Strategy __this = global::Java.Lang.Object.GetObject<global::Com.Pushlink.Android.Strategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Remind ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.pushlink.android']/class[@name='Strategy']/method[@name='remind' and count(parameter)=0]"
		[Register ("remind", "()Z", "GetRemindHandler")]
		protected abstract bool Remind ();

		static Delegate cb_unNotifyUser_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetUnNotifyUser_Landroid_content_Context_Handler ()
		{
			if (cb_unNotifyUser_Landroid_content_Context_ == null)
				cb_unNotifyUser_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UnNotifyUser_Landroid_content_Context_);
			return cb_unNotifyUser_Landroid_content_Context_;
		}

		static void n_UnNotifyUser_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Pushlink.Android.Strategy __this = global::Java.Lang.Object.GetObject<global::Com.Pushlink.Android.Strategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UnNotifyUser (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.pushlink.android']/class[@name='Strategy']/method[@name='unNotifyUser' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("unNotifyUser", "(Landroid/content/Context;)V", "GetUnNotifyUser_Landroid_content_Context_Handler")]
		protected abstract void UnNotifyUser (global::Android.Content.Context p0);

	}

	[global::Android.Runtime.Register ("com/pushlink/android/Strategy", DoNotGenerateAcw=true)]
	internal partial class StrategyInvoker : Strategy {

		public StrategyInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (StrategyInvoker); }
		}

		static IntPtr id_getHash;
		static IntPtr id_setHash_Ljava_lang_String_;
		protected override string Hash {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pushlink.android']/class[@name='Strategy']/method[@name='getHash' and count(parameter)=0]"
			[Register ("getHash", "()Ljava/lang/String;", "GetGetHashHandler")]
			get {
				if (id_getHash == IntPtr.Zero)
					id_getHash = JNIEnv.GetMethodID (class_ref, "getHash", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getHash), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.pushlink.android']/class[@name='Strategy']/method[@name='setHash' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setHash", "(Ljava/lang/String;)V", "GetSetHash_Ljava_lang_String_Handler")]
			set {
				if (id_setHash_Ljava_lang_String_ == IntPtr.Zero)
					id_setHash_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setHash", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.CallVoidMethod  (Handle, id_setHash_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr id_notifyUser_Landroid_content_Intent_Landroid_content_Context_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pushlink.android']/class[@name='Strategy']/method[@name='notifyUser' and count(parameter)=4 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='android.content.Context'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String']]"
		[Register ("notifyUser", "(Landroid/content/Intent;Landroid/content/Context;ILjava/lang/String;)V", "GetNotifyUser_Landroid_content_Intent_Landroid_content_Context_ILjava_lang_String_Handler")]
		protected override void NotifyUser (global::Android.Content.Intent p0, global::Android.Content.Context p1, int p2, string p3)
		{
			if (id_notifyUser_Landroid_content_Intent_Landroid_content_Context_ILjava_lang_String_ == IntPtr.Zero)
				id_notifyUser_Landroid_content_Intent_Landroid_content_Context_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "notifyUser", "(Landroid/content/Intent;Landroid/content/Context;ILjava/lang/String;)V");
			IntPtr native_p3 = JNIEnv.NewString (p3);
			JNIEnv.CallVoidMethod  (Handle, id_notifyUser_Landroid_content_Intent_Landroid_content_Context_ILjava_lang_String_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (native_p3));
			JNIEnv.DeleteLocalRef (native_p3);
		}

		static IntPtr id_remind;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pushlink.android']/class[@name='Strategy']/method[@name='remind' and count(parameter)=0]"
		[Register ("remind", "()Z", "GetRemindHandler")]
		protected override bool Remind ()
		{
			if (id_remind == IntPtr.Zero)
				id_remind = JNIEnv.GetMethodID (class_ref, "remind", "()Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_remind);
		}

		static IntPtr id_unNotifyUser_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.pushlink.android']/class[@name='Strategy']/method[@name='unNotifyUser' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("unNotifyUser", "(Landroid/content/Context;)V", "GetUnNotifyUser_Landroid_content_Context_Handler")]
		protected override void UnNotifyUser (global::Android.Content.Context p0)
		{
			if (id_unNotifyUser_Landroid_content_Context_ == IntPtr.Zero)
				id_unNotifyUser_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "unNotifyUser", "(Landroid/content/Context;)V");
			JNIEnv.CallVoidMethod  (Handle, id_unNotifyUser_Landroid_content_Context_, new JValue (p0));
		}

	}

}
