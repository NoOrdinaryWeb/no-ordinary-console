/// <binding AfterBuild='default' />
var gulp = require('gulp');
var del = require('del');

function clean() {
  return del([
    'NoOrdinary.Console.Template/Content/**/*'
  ]);
}

function move() {
  return gulp.src([
    'NoOrdinary.Console/**/*',
    '!NoOrdinary.Console/{bin,bin/**/*,obj,obj/**/*}',
    'NoOrdinary.Console/*.cs',
    'NoOrdinary.Console/*.csproj'
  ])
    .pipe(gulp.dest('NoOrdinary.Console.Template/Content'));
}

gulp.task('clean', gulp.series(clean));
gulp.task('default', gulp.series(clean, move));