using System.Drawing;

namespace paracode.NMagick
{

    public class TypeMetrics {
        private double _ascent = 0;
        private double _descent = 0;
        private double _height = 0;
        private double _maxAdvance = 0;
        private double _width = 0;

        public void compose(TypeMetrics metrics){
            
            if(metrics.getWidth() > getWidth()){
                this.setAscent( metrics.getAscent() );
                this.setDescent( metrics.getDescent() );
                this.setMaxAdvance( metrics.getMaxAdvance() );
                this.setWidth( metrics.getWidth() );
            }
            
            this.setHeight( this.getHeight() + metrics.getHeight() );
        }
        
        public static TypeMetrics fromFontMetrics(FontMetrics fontMetrics, string str){
            TypeMetrics metrics = new TypeMetrics();
            
            metrics.setAscent(fontMetrics.getAscent());
            metrics.setDescent(fontMetrics.getDescent());
            metrics.setHeight(fontMetrics.getHeight());
            metrics.setMaxAdvance(fontMetrics.getMaxAdvance());
            metrics.setWidth(fontMetrics.stringWidth(str));
            
            return metrics;
        }
        
        public double getAscent() {
            return _ascent;
        }

        public double getDescent() {
            return _descent;
        }

        public double getHeight() {
            return _height;
        }

        public double getMaxAdvance() {
            return _maxAdvance;
        }

        public double getWidth() {
            return _width;
        }

        public void setAscent(double ascent) {
            this._ascent = ascent;
        }

        public void setDescent(double descent) {
            this._descent = descent;
        }

        public void setHeight(double height) {
            this._height = height;
        }

        public void setMaxAdvance(double maxAdvance) {
            this._maxAdvance = maxAdvance;
        }

        public void setWidth(double width) {
            this._width = width;
        }
    }

    public class FontMetrics
    {
        private FontFamily _ffm;
        private FontStyle _fs;
        private Graphics _g;
        private Font _f;

        public FontMetrics(Graphics g, Font f)
        {
            _f = f;
            _ffm = f.FontFamily;
            _fs = f.Style;
            _g = g;
        }

        public double getAscent()
        {
            return _ffm.GetCellAscent(_fs);
        }

        public double getDescent()
        {
            return _ffm.GetCellDescent(_fs);
        }

        public double getHeight()
        {
            return _ffm.GetEmHeight(_fs);
        }

        public double getMaxAdvance()
        {
            return 0; //INAC: inaccuracy porting. need to get maxadvance in .net.
        }

        public double stringWidth(string str)
        {
            return _g.MeasureString(str, _f).Width;
        }
    }
}