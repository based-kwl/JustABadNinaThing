﻿#region "copyright"

/*
    Copyright © 2016 - 2020 Stefan Berg <isbeorn86+NINA@googlemail.com>

    This file is part of N.I.N.A. - Nighttime Imaging 'N' Astronomy.

    N.I.N.A. is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    N.I.N.A. is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with N.I.N.A..  If not, see <http://www.gnu.org/licenses/>.
*/

#endregion "copyright"

using System.Globalization;
using System.Windows.Controls;

namespace NINA.Utility.ValidationRules {

    public class SecondsRule : ValidationRule {

        public override ValidationResult Validate(object value, CultureInfo cultureInfo) {
            double doubleval = 0.0d;
            if (double.TryParse(value.ToString(), NumberStyles.Any, CultureInfo.InvariantCulture, out doubleval)) {
                if (doubleval < 0) {
                    return new ValidationResult(false, "Value must be greater than or equals 0");
                } else if (doubleval >= 60) {
                    return new ValidationResult(false, "Value must be less than 60");
                } else {
                    return new ValidationResult(true, null);
                }
            } else {
                return new ValidationResult(false, "Invalid value");
            }
        }
    }
}