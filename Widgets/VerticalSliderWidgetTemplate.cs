using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Prototype.Framework;

namespace Widgets
{
    public class VerticalSliderWidgetTemplate
      : StandardWidgetTemplate
    {
        public VerticalSliderWidgetTemplate()
            : base("VerticalSliderGraphic")
        {
            ID = "{75F96D09-6A1A-46DD-8CF7-CAF9E4A102D3}";
            this.Category = "Slider";
            this.Name = "Vertical Slider";
        }

        public override string CreateCodeSnippet(string itemId)
        {
            var snippet = string.Format(
              "<div idclass='sliderwidget'>{0}" +
              " <p>{0}" +
              "   <label for='{1}volume'>Volume</label>{0}" +
              "   <input type='test' id='value' style='border: 0; color: #f6931f; font-weight: bold;' />{0}" +
              " </p>{0}" +
              "</div>{0}" +
              "<script>{0}" +
              "   $(function() {{ {0}" +
              "       $( '#slider-range-min' ).slider({{ {0}" +
              "           range: 'min', {0}" +
              "           value: 37, {0}" +
              "           min: 1, {0}" +
              "           max: 100, {0}" +
              "           slide: function( event, ui ) {{ {0}" +
              "               $( '#volume' ).val( ui.value );{0}" +
              "           }}{0}" +
              "       }});{0}" +
              "       $( '#{1}volumn' ).val( $( '#slider-range-min' ).slider( 'value' ) );{0}" +
              "   }});{0}" +
              "</script>",
                /* 0 */ Environment.NewLine,
                /* 1 */ itemId);

            return snippet;
        }
    }
}