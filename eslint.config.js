// @ts-check
import path from 'node:path';
import { fileURLToPath } from 'node:url';

import { FlatCompat } from '@eslint/eslintrc';

import globals from 'globals';

import eslint from '@eslint/js';
import prettierConfig from 'eslint-config-prettier';
import tseslint from 'typescript-eslint';

// plugins
import noOnlyTestsEslint from 'eslint-plugin-no-only-tests';
import regexpEslint from 'eslint-plugin-regexp';
const typescriptEslint = tseslint.plugin;

// parsers
const typescriptParser = tseslint.parser;

const __filename = fileURLToPath(import.meta.url);
const __dirname = path.dirname(__filename);

// ref: https://eslint.org/docs/latest/use/configure/migration-guide#using-eslintrc-configs-in-flat-config
// mimic CommonJS variables -- not needed if using CommonJS
const compat = new FlatCompat({
	baseDirectory: __dirname
});

export default tseslint.config(
	eslint.configs.recommended,
	...compat.extends('plugin:regexp/recommended'),
	...tseslint.configs.recommendedTypeChecked,
	...tseslint.configs.stylisticTypeChecked,
	prettierConfig,
	{
		languageOptions: {
			parser: typescriptParser,
			parserOptions: {
				project: ['./tsconfig.eslint.json'],
				tsconfigRootDir: __dirname
			},
			globals: globals.browser
		},
		plugins: {
			'@typescript-eslint': typescriptEslint,
			'no-only-tests': noOnlyTestsEslint,
			regexp: regexpEslint
		}
	},
	{
		ignores: [
			'**/*.d.*',
			'**/*.map.*',
			'packages/**/*.min.js',
			'packages/**/dist/',
			'packages/**/fixtures/',
			'packages/astro/vendor/vite/',
			'benchmark/**/dist/',
			'examples/',
			'scripts/',
			'.github/',
			'.changeset/',
			'**/wwwroot/**/*.js',
			'eslint.config.js' //TODO: Remove an resolve the issues
		]
	}
);
