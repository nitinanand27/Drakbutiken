//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.5.96
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

namespace Umbraco.Web.PublishedContentModels
{
	// Mixin content Type 1082 with alias "abstractPageBackgroundImage"
	/// <summary>Abstract Page Background Image</summary>
	public partial interface IAbstractPageBackgroundImage : IPublishedContent
	{
		/// <summary>Hide Breadcrumb</summary>
		bool HideBreadcrumb { get; }

		/// <summary>Large height</summary>
		bool LargeHeight { get; }

		/// <summary>Background Image</summary>
		string PageBackgroundImage { get; }

		/// <summary>Summary</summary>
		string Summary { get; }

		/// <summary>Use Light Overlay</summary>
		bool UseLightOverlay { get; }

		/// <summary>Use Light Text Color</summary>
		bool UseLightTextColor { get; }

		/// <summary>Use Overlay</summary>
		bool UseOverlay { get; }
	}

	/// <summary>Abstract Page Background Image</summary>
	[PublishedContentModel("abstractPageBackgroundImage")]
	public partial class AbstractPageBackgroundImage : PublishedContentModel, IAbstractPageBackgroundImage
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "abstractPageBackgroundImage";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public AbstractPageBackgroundImage(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<AbstractPageBackgroundImage, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Hide Breadcrumb: Hides the generated breadcrumb from the top image. You can also globally hide all breadcrumbs by checking a box in Site Configuration.
		///</summary>
		[ImplementPropertyType("hideBreadcrumb")]
		public bool HideBreadcrumb
		{
			get { return GetHideBreadcrumb(this); }
		}

		/// <summary>Static getter for Hide Breadcrumb</summary>
		public static bool GetHideBreadcrumb(IAbstractPageBackgroundImage that) { return that.GetPropertyValue<bool>("hideBreadcrumb"); }

		///<summary>
		/// Large height: Set a height for the background image. If you check this box the image will have a larger height.
		///</summary>
		[ImplementPropertyType("largeHeight")]
		public bool LargeHeight
		{
			get { return GetLargeHeight(this); }
		}

		/// <summary>Static getter for Large height</summary>
		public static bool GetLargeHeight(IAbstractPageBackgroundImage that) { return that.GetPropertyValue<bool>("largeHeight"); }

		///<summary>
		/// Background Image: Optionally set a background image for the top section of the page. If you don't set an image then no other settings defined here will apply.
		///</summary>
		[ImplementPropertyType("pageBackgroundImage")]
		public string PageBackgroundImage
		{
			get { return GetPageBackgroundImage(this); }
		}

		/// <summary>Static getter for Background Image</summary>
		public static string GetPageBackgroundImage(IAbstractPageBackgroundImage that) { return that.GetPropertyValue<string>("pageBackgroundImage"); }

		///<summary>
		/// Summary: Enter a summary which will appear under the page title. If breadcrumbs are enabled summary will appear underneath the breadcrumb.
		///</summary>
		[ImplementPropertyType("summary")]
		public string Summary
		{
			get { return GetSummary(this); }
		}

		/// <summary>Static getter for Summary</summary>
		public static string GetSummary(IAbstractPageBackgroundImage that) { return that.GetPropertyValue<string>("summary"); }

		///<summary>
		/// Use Light Overlay: If you have checked "Use Overlay" above, check this box to use a light overlay. If you leave this box unchecked, a dark overlay will be used instead.
		///</summary>
		[ImplementPropertyType("useLightOverlay")]
		public bool UseLightOverlay
		{
			get { return GetUseLightOverlay(this); }
		}

		/// <summary>Static getter for Use Light Overlay</summary>
		public static bool GetUseLightOverlay(IAbstractPageBackgroundImage that) { return that.GetPropertyValue<bool>("useLightOverlay"); }

		///<summary>
		/// Use Light Text Color: Check to use light color for text. If unchecked, dark color will be used.
		///</summary>
		[ImplementPropertyType("useLightTextColor")]
		public bool UseLightTextColor
		{
			get { return GetUseLightTextColor(this); }
		}

		/// <summary>Static getter for Use Light Text Color</summary>
		public static bool GetUseLightTextColor(IAbstractPageBackgroundImage that) { return that.GetPropertyValue<bool>("useLightTextColor"); }

		///<summary>
		/// Use Overlay: If you have set a background image, you can use a dark or light overlay
		///</summary>
		[ImplementPropertyType("useOverlay")]
		public bool UseOverlay
		{
			get { return GetUseOverlay(this); }
		}

		/// <summary>Static getter for Use Overlay</summary>
		public static bool GetUseOverlay(IAbstractPageBackgroundImage that) { return that.GetPropertyValue<bool>("useOverlay"); }
	}
}
