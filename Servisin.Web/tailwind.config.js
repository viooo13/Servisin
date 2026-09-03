/** @type {import('tailwindcss').Config} */
module.exports = {
  content: [
    './Pages/**/*.cshtml',
    './Views/**/*.cshtml',
    './wwwroot/**/*.html',
  ],
  theme: {
    extend: {
      colors: {
        primary: '#0F172A',
        secondary: '#334155',
        cta: '#0369A1',
        background: '#F8FAFC',
        text: '#020617',
      },
      fontFamily: {
        sans: ['Plus Jakarta Sans', 'sans-serif'],
      },
    },
  },
  plugins: [],
}
