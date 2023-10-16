﻿using NUnit.Framework;
using System.Collections.Generic;


namespace BAI
{
    [TestFixture]
    public class Opdr3Tests
    {
        [TestCase("", "")]
        [TestCase("1 8 18 21 34 35 47 52 60 69 73 86 99 103 112 120 125 137 138 151 154 164 171 177 188 190 203 205 216 222 229 239 242 255", "1 18 34 112 177 242")]
        [TestCase("0 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28 29 30 31 32 33 34 35 36 37 38 39 40 41 42 43 44 45 46 47 48 49 50 51 52 53 54 55 56 57 58 59 60 61 62 63 64 65 66 67 68 69 70 71 72 73 74 75 76 77 78 79 80 81 82 83 84 85 86 87 88 89 90 91 92 93 94 95 96 97 98 99 100 101 102 103 104 105 106 107 108 109 110 111 112 113 114 115 116 117 118 119 120 121 122 123 124 125 126 127 128 129 130 131 132 133 134 135 136 137 138 139 140 141 142 143 144 145 146 147 148 149 150 151 152 153 154 155 156 157 158 159 160 161 162 163 164 165 166 167 168 169 170 171 172 173 174 175 176 177 178 179 180 181 182 183 184 185 186 187 188 189 190 191 192 193 194 195 196 197 198 199 200 201 202 203 204 205 206 207 208 209 210 211 212 213 214 215 216 217 218 219 220 221 222 223 224 225 226 227 228 229 230 231 232 233 234 235 236 237 238 239 240 241 242 243 244 245 246 247 248 249 250 251 252 253 254 255", "0 1 2 16 17 18 32 33 34 48 49 50 64 65 66 80 81 82 96 97 98 112 113 114 128 129 130 144 145 146 160 161 162 176 177 178 192 193 194 208 209 210 224 225 226 240 241 242")]
        public void Opdr3_a_IDLager3_ZonderLicht(string input, string expected)
        {
            // Prepare
            List<uint> input_array = TestUtils.UIntListFromString(input);

            // Act
            HashSet<uint> actual_set = BAI_Afteken2.Opdr3a(input_array);
            string actual = TestUtils.EnumSortedToString(actual_set);

            // Assert
            Assert.AreEqual(expected, actual);
        }


        [TestCase("", "")]
        [TestCase("1 8 18 21 34 35 47 52 60 69 73 86 99 103 112 120 125 137 138 151 154 164 171 177 188 190 203 205 216 222 229 239 242 255", "8 21 35 47 52 60 69 73 86 99 103 120 125 137 138 151 154 164 171 188 190 203 205 216 222 229 239 255")]
        [TestCase("0 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28 29 30 31 32 33 34 35 36 37 38 39 40 41 42 43 44 45 46 47 48 49 50 51 52 53 54 55 56 57 58 59 60 61 62 63 64 65 66 67 68 69 70 71 72 73 74 75 76 77 78 79 80 81 82 83 84 85 86 87 88 89 90 91 92 93 94 95 96 97 98 99 100 101 102 103 104 105 106 107 108 109 110 111 112 113 114 115 116 117 118 119 120 121 122 123 124 125 126 127 128 129 130 131 132 133 134 135 136 137 138 139 140 141 142 143 144 145 146 147 148 149 150 151 152 153 154 155 156 157 158 159 160 161 162 163 164 165 166 167 168 169 170 171 172 173 174 175 176 177 178 179 180 181 182 183 184 185 186 187 188 189 190 191 192 193 194 195 196 197 198 199 200 201 202 203 204 205 206 207 208 209 210 211 212 213 214 215 216 217 218 219 220 221 222 223 224 225 226 227 228 229 230 231 232 233 234 235 236 237 238 239 240 241 242 243 244 245 246 247 248 249 250 251 252 253 254 255", "3 4 5 6 7 8 9 10 11 12 13 14 15 19 20 21 22 23 24 25 26 27 28 29 30 31 35 36 37 38 39 40 41 42 43 44 45 46 47 51 52 53 54 55 56 57 58 59 60 61 62 63 67 68 69 70 71 72 73 74 75 76 77 78 79 83 84 85 86 87 88 89 90 91 92 93 94 95 99 100 101 102 103 104 105 106 107 108 109 110 111 115 116 117 118 119 120 121 122 123 124 125 126 127 131 132 133 134 135 136 137 138 139 140 141 142 143 147 148 149 150 151 152 153 154 155 156 157 158 159 163 164 165 166 167 168 169 170 171 172 173 174 175 179 180 181 182 183 184 185 186 187 188 189 190 191 195 196 197 198 199 200 201 202 203 204 205 206 207 211 212 213 214 215 216 217 218 219 220 221 222 223 227 228 229 230 231 232 233 234 235 236 237 238 239 243 244 245 246 247 248 249 250 251 252 253 254 255")]
        public void Opdr3_b_IDHoger2_MetLicht(string input, string expected)
        {
            // Prepare
            List<uint> input_array = TestUtils.UIntListFromString(input);

            // Act
            HashSet<uint> actual_set = BAI_Afteken2.Opdr3b(input_array);
            string actual = TestUtils.EnumSortedToString(actual_set);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}